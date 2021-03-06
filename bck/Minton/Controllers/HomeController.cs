﻿using Milton.Model;
using Milton.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Milton.Controllers
{


    public class HomeController : Controller
    {
        private readonly BopDb _db = new BopDb();
        public ActionResult Index()
        {
            if (System.Web.HttpContext.Current.Session["Session"] == null) return RedirectToAction("Login", "Account");
            if (!Convert.ToBoolean(System.Web.HttpContext.Current.Session["Session"])) return RedirectToAction("Login", "Account");
            var query = "select AppCode as Id, Name as Name from AppContract";
            var apps = _db.Database.SqlQuery<Apps>(query).ToList();
            System.Web.HttpContext.Current.Session["Apps"] = apps;
            return View(apps);
        }

        [AllowAnonymous]
        [HttpGet]
        public JsonResult acti(string appId, string initialDate, string endDate)
        {
            var rtn = new General();
            var initial = Convert.ToDateTime(initialDate).ToString("yyyy/MM/dd");
            var ending = Convert.ToDateTime(endDate).ToString("yyyy/MM/dd");
            try
            {
                var query = "exec sp_info_usuarios_intervalo '" + appId + "', '" + initial + "', '" + ending + "'";
                rtn.Interval = _db.Database.SqlQuery<Intervalo>(query).ToList();
                query = "exec sp_info_dashboard '" + appId + "', '" + initial + "'";
                rtn.ReportGeneral = _db.Database.SqlQuery<Tables>(query).ToList();
                rtn.ReportGeneral = rtn.ReportGeneral.Where(x => DateTime.Compare(x.Fecha, Convert.ToDateTime(ending)) <= 0).ToList();
                var sr = rtn.ReportGeneral.Select(x => x.Suscripciones).Sum(a => a);
                rtn.Charged = rtn.ReportGeneral.Select(x => x.daily_charged).Sum(a => a);
                rtn.ActiveUsers = rtn.ReportGeneral.Select(x => x.Suscripciones).Sum(a => a);
                rtn.Registered = rtn.ReportGeneral.Select(x => x.Registrados).Sum(a => a);
                rtn.Cancellation = 0;
                var td = rtn.ActiveUsers - rtn.Cancellation;
                rtn.SubcribedUsers = td;
                rtn.ValuesPerMonth = new List<ValMonth>();
                var months = GetMonths();
                foreach (var month in months)
                    rtn.ValuesPerMonth.Add(GetValuesPerMotnh(month, rtn.ReportGeneral));
                var companies = System.Web.HttpContext.Current.Session["Apps"] as List<Apps>;
                rtn.CompaniesMetrics = new List<CpMetrics>();
                foreach (var company in companies)
                {
                    query = "exec sp_info_dashboard '" + company.Id + "', '" + initial + "'";
                    var rpt = _db.Database.SqlQuery<Tables>(query).ToList();
                    rpt = rpt.Where(x => DateTime.Compare(x.Fecha, Convert.ToDateTime(ending)) <= 0).ToList();
                    rtn.CompaniesMetrics.Add(new CpMetrics
                    {
                        Name = company.Name,
                        Value = rpt.Select(x => x.Suscripciones).Sum(a => a).ToString()
                    });
                }

                foreach (var report in rtn.ReportGeneral) report.Date = report.Fecha.ToString("yyyy/MM/dd");
            }
            catch (Exception)
            {
                //
            }
            return Json(rtn, JsonRequestBehavior.AllowGet);
        }

        private List<DateMonth> GetMonths()
        {
            var lastTwelveMonths = Enumerable
                .Range(0, 12)
                .Select(i => DateTime.Now.AddMonths(i - 12))
                .Select(date => date.ToString("MM-yyyy"));
            return lastTwelveMonths.Select(month => month.Split('-'))
                .Select(spt => new DateMonth
                {
                    Month = Convert.ToInt32(spt[0]),
                    Year = Convert.ToInt32(spt[1]),
                    MonthName = GetMonthName(Convert.ToInt32(spt[0]))
                })
                .ToList();
        }

        private string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
            }
            return "";
        }

        private ValMonth GetValuesPerMotnh(DateMonth month, List<Tables> values)
        {
            var valid = values.Where(x => x.Fecha.Month == month.Month && x.Fecha.Year == month.Year).ToList();
            return new ValMonth
            {
                Cancellation = "0",
                Activation = valid.Select(x => x.registrados_con_pago_activo).Sum(a => a).ToString(),
                Month = month.Month,
                Year = month.Year,
                MonthName = month.MonthName,
                Subscription = valid.Select(x => x.Suscripciones).Sum(a => a).ToString()
            };
        }

        private List<GetInfo> info(int CellPhone)
        {
            if (CellPhone != 0)
            {
                var query = @"	SELECT	a.status_id as StatusId,
							a.user_email as UserEmail,
							a.user_icard as UserIcard,
							a.user_icardtitular as UserIcardtitular,
							a.user_id as UserId,
							a.user_lastname as UserLastname,
							a.user_firstname as UserName,
							a.user_uc as UserUc,
							a.user_firstname as Name,
							a.user_sellerCode as SellerCode,
							b.lang_short as UserLanguage,
							b.lang_description as UserLanguageDescription, 
							a.user_password_changed as PasswordChanged,
							c.country_id as CountryId,
							c.country_name as Country,
							a.user_address as Address,
							CONVERT(VARCHAR(11),a.user_birthdate,111) as Birthdate,
							a.user_cellphone as CellPhone,
							a.user_gender as Gender, 'Group' as 'Group',
							1 as GroupId,
							b.lang_id as LanguageId,
							CONVERT(VARCHAR(11),a.user_last_activity,111) as LastActivity,
							a.user_urlimg as pictureUrl,
							g.AppCode as AppId,
							a.CarNumber as CarNumber,
							g.name as AppName,
							(SELECT token FROM token WHERE cellphone=a.user_cellphone)	AS ExternalUserId		
					FROM users a
					join languages b on a.user_lang = b.lang_id
					join country c on a.country_id = c.country_id
					--join usersXgroup d on a.user_id = d.user_id
					--join groupXentity e on d.groupenti_id = e.groupenti_id
					join AppXUser f ON f.IdUser = a.user_id
					join AppContract g on g.Id = f.IdAppContract
					WHERE a.user_cellphone = '" + CellPhone + "'";

                return _db.Database.SqlQuery<GetInfo>(query).ToList();

            }
        }
    }
}










