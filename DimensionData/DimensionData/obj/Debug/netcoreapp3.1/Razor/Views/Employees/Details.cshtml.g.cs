#pragma checksum "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6bb334f627597c6e0aab6d2d54aef020b9db418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\DimensionDataProject\DimensionData\DimensionData\Views\_ViewImports.cshtml"
using DimensionData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DimensionDataProject\DimensionData\DimensionData\Views\_ViewImports.cshtml"
using DimensionData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6bb334f627597c6e0aab6d2d54aef020b9db418", @"/Views/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d673c126677dd967c77b914e2d79ad5bedf4bf66", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DimensionData.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" background-color: #FF9933; color: white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emp.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Emp.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edu.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edu.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Edu.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Edu.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Job.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pay.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pay.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pay.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pay.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pay.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pay.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Survey.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Survey.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Survey.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpPerformance.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpPerformance.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpPerformance.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpPerformance.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpPerformance.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmpPerformance.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6bb334f627597c6e0aab6d2d54aef020b9db41828642", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 226 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Details.cshtml"
                           WriteLiteral(Model.EmployeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6bb334f627597c6e0aab6d2d54aef020b9db41830967", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DimensionData.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
