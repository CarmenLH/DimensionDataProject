#pragma checksum "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7924e84f4a7d28db19c8a685b68ee95ea1dc5833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Delete), @"mvc.1.0.view", @"/Views/Employees/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7924e84f4a7d28db19c8a685b68ee95ea1dc5833", @"/Views/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d673c126677dd967c77b914e2d79ad5bedf4bf66", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DimensionData.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Emp.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Emp.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Emp.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Emp.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Edu.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Edu.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Edu.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Edu.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpHistory.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpHistory.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Job.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Job.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pay.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pay.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pay.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pay.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pay.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pay.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pay.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Survey.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Survey.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Survey.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpPerformance.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpPerformance.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpPerformance.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpPerformance.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 219 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmpPerformance.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 222 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmpPerformance.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7924e84f4a7d28db19c8a685b68ee95ea1dc583328252", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7924e84f4a7d28db19c8a685b68ee95ea1dc583328519", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 271 "E:\DimensionDataProject\DimensionData\DimensionData\Views\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7924e84f4a7d28db19c8a685b68ee95ea1dc583330321", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
