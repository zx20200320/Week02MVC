using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week02MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
//        go
//alter proc pr_sel
//(
//@name varchar(20),
//@startTime varchar(20),
//@endTime varchar(20),
//@warrant varchar(20),
//@liXi int=0
//)
//as
//begin
//    declare @sql Nvarchar(500)

//    set @sql = N'select * from Loans where 1=1'

//	if(@name!='' and @name is not null)
//	begin
//        set @sql=@sql+N'and Name like ''%'+@name+'%'''
//	end

//	if(@startTime!='' and @startTime is not null)
//	begin
//        set @sql=@sql+ N'and StartTime > '''+@startTime+''''
//	end

//	if(@endTime!='' and @endTime is not null)
//	begin
//        set @sql=@sql+ N'and EndTime < '''+@endTime+''''
//	end

//	if(@warrant!='' and @warrant is not null)
//	begin
//        set @sql=@sql+ N'and Warrant= ''' +@warrant+''''
//	end

//	if(@liXi is not null)
//	begin
//        set @sql=@sql+ N'and LiXi= '''+convert(nvarchar(50),@liXi)+''''
//	end
//    exec sp_executesql @sql
//end

//exec pr_sel '张三','2020-03-25','2020-06-25','',1
    }
}