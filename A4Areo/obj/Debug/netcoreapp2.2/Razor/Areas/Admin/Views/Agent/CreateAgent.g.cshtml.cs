#pragma checksum "E:\Work\A4Areo\A4Areo\Areas\Admin\Views\Agent\CreateAgent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e0318cec761393a83d8c39e1f06f1eb1810e88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Agent_CreateAgent), @"mvc.1.0.view", @"/Areas/Admin/Views/Agent/CreateAgent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Agent/CreateAgent.cshtml", typeof(AspNetCore.Areas_Admin_Views_Agent_CreateAgent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e0318cec761393a83d8c39e1f06f1eb1810e88", @"/Areas/Admin/Views/Agent/CreateAgent.cshtml")]
    public class Areas_Admin_Views_Agent_CreateAgent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Work\A4Areo\A4Areo\Areas\Admin\Views\Agent\CreateAgent.cshtml"
  
    ViewData["Title"] = "CreateAgent";

#line default
#line hidden
            BeginContext(49, 69, true);
            WriteLiteral("\r\n<h4>Create  Agent</h4>\r\n<small>Agents > Create  Agent</small>\r\n\r\n\r\n");
            EndContext();
            BeginContext(118, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43e0318cec761393a83d8c39e1f06f1eb1810e883525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 7176, true);
            WriteLiteral(@"

<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>

<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""panel panel-white"" id=""panel5"">
            <div class=""panel-heading"">
                <div>
                    <a class=""btn btn-primary pull-right"" href=""/Admin/Agent/AgentList""><i class=""fa fa-list-ul""></i> View List</a>
                </div>
                <div class=""panel-tools"">
                    <a data-original-title=""Collapse"" data-toggle=""tooltip"" data-placement=""top"" class=""btn btn-transparent btn-sm panel-collapse"" href=""#""><i class=""ti-minus collapse-off""></i><i class=""ti-plus collapse-on""></i></a>
                </div>
            </div>
            <div class=""panel-body"" style=""display: block;"">
                <form class=""form-horizontal"" id=""formPost"">

                    <input type=""hidden"" id=""businessId"" />

                    <div class=""col-md-5"">
                        <div class=""col-sm-12"">
                ");
            WriteLiteral(@"            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Code <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""code"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Email <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""email"" class=""form-control"" id=""email"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
         ");
            WriteLiteral(@"                   <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Name <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""name"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Street <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""street"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
 ");
            WriteLiteral(@"                           <div class=""form-group"">
                                <label class=""control-label col-sm-2"">City <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""city"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">State <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""state"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-1");
            WriteLiteral(@"2"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Zip <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""zip"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Country <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""country"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""");
            WriteLiteral(@"col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Mobile <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""mobile"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Phone <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""phone"" required />

                                </div>
                            </div>
                        </div>

                        <d");
            WriteLiteral(@"iv class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">ContactPerson <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""contactPerson"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">ReferredBy <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""referredBy"" required />

                                </div>
                            </div>
                        </");
            WriteLiteral("div>\r\n\r\n");
            EndContext();
            BeginContext(7856, 1150, true);
            WriteLiteral(@"
                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Balance <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""balance"" required />

                                </div>
                            </div>
                        </div>

                        <div class=""col-sm-12"">
                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">CurrentBalance <span class=""symbol required"" aria-required=""true""></span></label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" id=""currentBalance"" required />

                                </div>
                            </div>
  ");
            WriteLiteral("                      </div>\r\n\r\n                    \r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n");
            EndContext();
            BeginContext(9414, 8126, true);
            WriteLiteral(@"

                        <div class=""col-sm-12"">
                            <div> <label class=""control-label"">Status <span class=""symbol required"" aria-required=""true""></span></label></div>
                            <label class=""radio-inline""><input type=""radio"" value=""2"" name=""statusRadio"" checked>NEW</label>
                            <label class=""radio-inline""><input type=""radio"" value=""1"" name=""statusRadio"">ACTIVE</label>
                            <label class=""radio-inline""><input type=""radio"" value=""0"" name=""statusRadio"">INACTIVE </label>
                        </div>

                        <div class=""col-sm-12"">
                            <div> <label class=""control-label"">Logo <span class=""symbol required"" aria-required=""true""></span></label></div>
                            <input id=""logo"" type='file'>
                            <input type=""hidden"" id=""hdnLogo"" />
                            <img id=""img"" height=""150"">
                        </div>

               ");
            WriteLiteral(@"     </div>
                  





                    <div class=""col-sm-12"">
                        <div class=""form-group"">
                            <input type=""submit"" value=""Save"" id=""btnSaveAgent"" class=""btn btn-primary"" />
                            <button type=""submit"" id=""btnUpdateAgent"" class=""btn btn-primary"">Update</button>
                        </div>
                    </div>



                </form>
            </div>
        </div>
    </div>
</div>




<script>

    $(function () {
        var businessId = getUrlVars()[""businessId""];
        if (businessId != null) {
            //alert(businessId);
            editProduct(businessId);
            $(""#businessId"").val(businessId);
            $(""#btnSaveAgent"").hide();
        }
        else {
            $(""#btnUpdateAgent"").hide();
        }


    });


    function getUrlVars() {
        var vars = [], hash;
        var hashes = window.location.href.slice(window.location.href.indexO");
            WriteLiteral(@"f('?') + 1).split('&');
        for (var i = 0; i < hashes.length; i++) {
            hash = hashes[i].split('=');
            vars.push(hash[0]);
            vars[hash[0]] = hash[1];
        }
        return vars;
    }

    function editProduct(id) {


        var model = {
            BusinessId: id
        }


        $.ajax({
            type: ""POST"",
            url: ""/Admin/Agent/GetAgent"",
            data: JSON.stringify(model),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (data) {


                $(""#code"").val(data.Code),
                    $(""#email"").val(data.Email),
                    $(""#name"").val(data.Name),
                    $(""#street"").val(data.Street),
                    $(""#city"").val(data.City),
                    $(""#state"").val(data.State),
                    $(""#zip"").val(data.Zip),
                    $(""#country"").val(data.Country),
                    $(""#mobile"").");
            WriteLiteral(@"val(data.Mobile),
                    $(""#phone"").val(data.Phone),
                    $(""#contactPerson"").val(data.ContactPerson),
                    $(""#referredBy"").val(data.ReferredBy),
                    $(""input[name=statusRadio][value="" + data.Status + ""]"").attr('checked', 'checked'),

                    $(""#balance"").val(data.Balance),
                    $(""#currentBalance"").val(data.CurrentBalance)
            }
        });

    };




    $(""#btnUpdateAgent"").click(function () {

        //var files = $(""#fileInput"").get(0).files;

        var data =
        {
            ""BusinessId"": $(""#businessId"").val(),
            ""Code"": $(""#code"").val(),
            ""Email"": $(""#email"").val(),
            ""Name"": $(""#name"").val(),
            ""Street"": $(""#street"").val(),
            ""City"": $(""#city"").val(),
            ""State"": $(""#state"").val(),
            ""Zip"": $(""#zip"").val(),
            ""Country"": $(""#country"").val(),
            ""Mobile"": $(""#mobile"").val(),
   ");
            WriteLiteral(@"         ""Phone"": $(""#phone"").val(),
            ""ContactPerson"": $(""#contactPerson"").val(),
            ""ReferredBy"": $(""#referredBy"").val(),
            ""Status"": $(""input[name='statusRadio']:checked"").val(),
            ""Balance"": $(""#balance"").val(),
            ""CurrentBalance"": $(""#currentBalance"").val(),
             ""Logo"": $(""#hdnLogo"").val(),
        }
        //if (files.length > 0) {
        //    data.Logo = files[0];
        //}
        console.log(data);

        $.ajax({
            type: ""POST"",
            url: ""/Admin/Agent/CreateAgent"",
            data: JSON.stringify(data),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (data) {
                //console.log(data);

                if (data.Success === ""success"") {
                    swal(""Agent Updated!"", ""Agent Info updated Successfully!!!"", ""success"");
                    clear();
                }
            }
        });



    ");
            WriteLiteral(@"});



    $(""#btnSaveAgent"").click(function (e) {

       
        if ($(""#formPost"")[0].checkValidity()) {
            var data =
            {
                ""Code"": $(""#code"").val(),
                ""Email"": $(""#email"").val(),
                ""Name"": $(""#name"").val(),
                ""Street"": $(""#street"").val(),
                ""City"": $(""#city"").val(),
                ""State"": $(""#state"").val(),
                ""Zip"": $(""#zip"").val(),
                ""Country"": $(""#country"").val(),
                ""Mobile"": $(""#mobile"").val(),
                ""Phone"": $(""#phone"").val(),
                ""ContactPerson"": $(""#contactPerson"").val(),
                ""ReferredBy"": $(""#referredBy"").val(),
                ""Balance"": parseFloat($(""#balance"").val()),
                ""CurrentBalance"": parseFloat($(""#currentBalance"").val()),
                ""Status"": $(""input[name='statusRadio']:checked"").val(),
                ""Logo"": $(""#hdnLogo"").val(),
            }

            console.log(data);
");
            WriteLiteral(@"
            $.ajax({
                type: ""POST"",
                url: ""/Admin/Agent/CreateAgent"",
                data: JSON.stringify(data),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (data) {
                    //console.log(data);

                    if (data.Success === ""success"") {
                        swal(""Agent Added!"", ""Agent Added Successfully!!!"", ""success"");
                        clear();
                    }
                }
            });
            e.preventDefault(e);
            return false;
        }
        



    });








    function readFile() {

        if (this.files && this.files[0]) {

            var FR = new FileReader();

            FR.addEventListener(""load"", function (e) {
                document.getElementById(""img"").src = e.target.result;
                document.getElementById(""hdnLogo"").value = e.target.result;
            });");
            WriteLiteral(@"

            FR.readAsDataURL(this.files[0]);
        }

    }


    document.getElementById(""logo"").addEventListener(""change"", readFile);



    function clear() {

        $(""#code"").val(""""),
            $(""#email"").val(""""),
            $(""#name"").val(""""),
            $(""#street"").val(""""),
            $(""#city"").val(""""),
            $(""#state"").val(""""),
            $(""#zip"").val(""""),
            $(""#country"").val(""""),
            $(""#mobile"").val(""""),
            $(""#phone"").val(""""),
            $(""#contactPerson"").val(""""),
            $(""#referredBy"").val(""""),
            $(""#status"").val(""""),
            $(""#balance"").val(""""),
            $(""#currentBalance"").val(""""),
            $(""#logo"").val(""""),
            $(""#img"").removeAttr(""src""),
            
            $(""input[name=statusRadio][value=2]"").attr('checked', 'checked');
            document.getElementById(""imgSrc"").src = """";

    }


</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591