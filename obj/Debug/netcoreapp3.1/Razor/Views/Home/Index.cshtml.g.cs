#pragma checksum "D:\Dental\DentoWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76bdf5cdc21b13b7b32f78c31a318b28318d699a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Dental\DentoWeb\Views\_ViewImports.cshtml"
using ProyDentoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dental\DentoWeb\Views\_ViewImports.cshtml"
using ProyDentoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76bdf5cdc21b13b7b32f78c31a318b28318d699a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb7939409e989001d98734c702361b623a08d69b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("footer-subscribe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("footer-subscribe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString(".site-navbar-target"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Dental\DentoWeb\Views\Home\Index.cshtml"
  
Layout=null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76bdf5cdc21b13b7b32f78c31a318b28318d699a5977", async() => {
                WriteLiteral(@"
    <title>Medically &mdash; </title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans:wght@400;700&family=Playfair+Display:wght@400;700&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""fonts/icomoon/style.css"">

    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/jquery-ui.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""css/owl.theme.default.min.css"">

    <link rel=""stylesheet"" href=""css/jquery.fancybox.min.css"">

    <link rel=""stylesheet"" href=""css/bootstrap-datepicker.css"">

    <link rel=""stylesheet"" href=""fonts/flaticon/font/flaticon.css"">

    <link rel=""stylesheet"" href=""css/aos.css"">

    <link rel=""stylesheet"" href=""css/style.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76bdf5cdc21b13b7b32f78c31a318b28318d699a7982", async() => {
                WriteLiteral(@"


    <div id=""overlayer""></div>
    <div class=""loader"">
        <div class=""spinner-border text-primary"" role=""status"">
            <span class=""sr-only"">Loading...</span>
        </div>
    </div>


    <div class=""site-wrap"">

        <div class=""site-mobile-menu site-navbar-target"">
            <div class=""site-mobile-menu-header"">
                <div class=""site-mobile-menu-close mt-3"">
                    <span class=""icon-close2 js-menu-toggle""></span>
                </div>
            </div>
            <div class=""site-mobile-menu-body""></div>
        </div>


        <header class=""site-navbar light js-sticky-header site-navbar-target"" role=""banner"">

            <div class=""container"">
                <div class=""row align-items-center"">

                    <div class=""col-6 col-xl-2"">
                        <div class=""mb-0 site-logo""><a href=""index.html"" class=""mb-0""><span class=""text-primary"">DentoWeb</span> </a></div>
                        <div class=""btn b");
                WriteLiteral(@"tn-outline-light""><a href=""/auth/Login"" class=""mb-5"">
                            <span class=""text-primary"">Login </span> </a>
                        </div> 
                        <div class=""btn btn-outline-light""><a href=""/auth/LoginDoctor"" class=""mb-5"">
                            <span class=""text-primary"">Login Doctor</span> </a>
                        </div> 
                        <div class=""btn btn-outline-light""><a href=""/Cliente/Create"" class=""mb-5"">
                            <span class=""text-primary"">Registrarse</span> </a>
                        </div>
                   
                        
                    </div>

                    <div class=""col-12 col-md-10 d-none d-xl-block"">
                        <nav class=""site-navigation position-relative text-right"" role=""navigation"">

                            <ul class=""site-menu main-menu js-clone-nav mr-auto d-none d-lg-block"">
                                <li><a href=""/"" class=""nav-link active"">Home</a><");
                WriteLiteral(@"/li>
                                <li class=""has-children"">
                                    <a href=""#"" class=""nav-link"">Login </a>
                                    <ul class=""dropdown"">
                                        <li><a href=""/auth/Login"" class=""nav-link"">Login Ciente</a></li>
                                        <li><a href=""/auth/loginDoctor"" class=""nav-link"">Login Doctor</a></li>
                                       
                                    </ul>
                                </li>



                            </ul>
                        </nav>
                    </div>


                    <div class=""col-6 d-inline-block d-xl-none ml-md-0 py-3"" style=""position: relative; top: 3px;""><a href=""#"" class=""site-menu-toggle js-menu-toggle float-right""><span class=""icon-menu h3 text-black""></span></a></div>

                </div>
            </div>

        </header>


        <!-- MAIN -->



        <div class=""slide-item overlay"" s");
                WriteLiteral(@"tyle=""background-image: url('images/hero_1.jpg')"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6 align-self-center"">
                        <h1 class=""heading mb-5"">Brindamos las mejores soluciones para su sonrisa</h1>
                        <p><a href=""#"" class=""btn btn-primary"">Separa tu cita</a></p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""container quick-contact"">
            <div class=""row"">
                <div class=""col-lg-4"">
                    <a href=""#"" class=""link-lg d-flex align-items-center"">
                        <span class=""icon-phone""></span>
                        <div>
                            <span>Give us a call</span>
                            <strong>1-999-123-4567</strong>
                        </div>
                    </a>
                </div>
                <div class=""col-lg-4"">
                    <a href=""#"" cl");
                WriteLiteral(@"ass=""link-lg d-flex align-items-center"">
                        <span class=""icon-envelope""></span>
                        <div>
                            <span>Send us a message</span>
                            <strong>info@medically.com</strong>
                        </div>
                    </a>
                </div>
                <div class=""col-lg-4"">
                    <a href=""#"" class=""link-lg d-flex align-items-center"">
                        <span class=""icon-room""></span>
                        <div>
                            <span>Visit us</span>
                            <strong>2918 Fake Street</strong>
                        </div>
                    </a>
                </div>
            </div>
        </div>



        <div class=""site-section"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <p><img src=""images/about.png"" alt=""Image"" class=""img-fluid""></p>");
                WriteLiteral(@"
                    </div>
                    <div class=""col-lg-5 ml-auto"">
                        <span class=""subheading"">About Us</span>
                        <h2 class=""heading""><strong class=""text-primary"">We Are Happy To Serve You!</strong></h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Architecto, neque, dolorem. Iusto dolore omnis ex vero consequatur et deserunt officia incidunt at illum corrupti adipisci consectetur, veniam veritatis? Neque, cupiditate.</p>
                        <p><a href=""#"" class=""btn btn-primary"">Contact Us</a> <a href=""#"" class=""btn btn-secondary"">Read More</a></p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-section bg-1"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-5 mr-auto"">
                        <span class=""subheading"">Our Mission</span>
                        <h2 class=""head");
                WriteLiteral(@"ing"">We Provide <strong class=""text-primary"">High Solutions</strong> for Your Health</h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Architecto, neque, dolorem. Iusto dolore omnis ex vero consequatur et deserunt officia incidunt.</p>

                    </div>
                    <div class=""col-lg-6"">
                        <figure class=""video-image"">
                            <a href=""https://www.youtube.com/watch?v=vSndrIBTDUw"" data-fancybox class=""btn-play""><span class=""icon-play""></span></a>
                            <img src=""images/img_3.jpg"" alt=""Image"" class=""img-fluid"">
                        </figure>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-section"">
            <div class=""container"">
                <div class=""row mb-5"">
                    <div class=""col-lg-7 mx-auto text-center"">
                        <span class=""subheading"">Our Services</span>
        ");
                WriteLiteral(@"                <h2 class=""heading""><strong class=""text-primary"">Health Services</strong> We Provided</h2>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-4"">
                        <a href=""#"" class=""service-v1 text-center"">
                            <span class=""flaticon-stethoscope""></span>
                            <h3>General Surgery</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus, ex!</p>
                        </a>
                    </div>
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-4"">
                        <a href=""#"" class=""service-v1 text-center"">
                            <span class=""flaticon-telephone""></span>
                            <h3>Outpatient Services</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus, ");
                WriteLiteral(@"ex!</p>
                        </a>
                    </div>
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-4"">
                        <a href=""#"" class=""service-v1 text-center"">
                            <span class=""flaticon-sphygmomanometer""></span>
                            <h3>Respiratory Therapy</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus, ex!</p>
                        </a>
                    </div>


                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-4"">
                        <a href=""#"" class=""service-v1 text-center"">
                            <span class=""flaticon-dna""></span>
                            <h3>Cardiac Clinic</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus, ex!</p>
                        </a>
                    </div>
                    <div class=""col-6 col-sm-6 col-md-6 col-l");
                WriteLiteral(@"g-4 mb-4 mb-lg-4"">
                        <a href=""#"" class=""service-v1 text-center"">
                            <span class=""flaticon-thermometer""></span>
                            <h3>Laryngological Service</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus, ex!</p>
                        </a>
                    </div>
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-4"">
                        <a href=""#"" class=""service-v1 text-center"">
                            <span class=""flaticon-syringe""></span>
                            <h3>Respiratory Therapy</h3>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatibus, ex!</p>
                        </a>
                    </div>

                </div>
            </div>
        </div>


        <div class=""site-section bg-light title-wrap-section"">
            <div class=""container"">
                <di");
                WriteLiteral(@"v class=""row"">
                    <div class=""col-lg-7 mx-auto text-center"">
                        <span class=""subheading"">Our Team</span>
                        <h2 class=""heading""><strong class=""text-primary"">Our Dedicated</strong> Doctors</h2>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-section overlap-section"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-0"">
                        <a href=""#"" class=""team"">
                            <img src=""images/person_1.jpg"" alt=""Image"" class=""img-fluid"">
                            <div class=""team-inner"">
                                <h3>Dr. Jade Guzman</h3>
                                <span>Cardiologist</span>
                            </div>
                        </a>
                    </div>
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 m");
                WriteLiteral(@"b-4 mb-lg-0"">
                        <a href=""#"" class=""team"">
                            <img src=""images/person_2.jpg"" alt=""Image"" class=""img-fluid"">
                            <div class=""team-inner"">
                                <h3>Dr. Hannah Ford</h3>
                                <span>Dermatologist</span>
                            </div>
                        </a>
                    </div>
                    <div class=""col-6 col-sm-6 col-md-6 col-lg-4 mb-4 mb-lg-0"">
                        <a href=""#"" class=""team"">
                            <img src=""images/person_3.jpg"" alt=""Image"" class=""img-fluid"">
                            <div class=""team-inner"">
                                <h3>Dr. James Wilson</h3>
                                <span>Surgeon</span>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-section bg-light"">
          ");
                WriteLiteral(@"  <div class=""container"">
                <div class=""row mb-5"">
                    <div class=""col-lg-7 mx-auto text-center mb-5"">
                        <span class=""subheading"">What Client Says</span>
                        <h2 class=""heading""><strong class=""text-primary"">Happy</strong> Patients</h2>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-4"">
                        <div class=""testimonial text-center"">
                            <img src=""images/patient_1.jpg"" alt=""Image"" class=""img-fluid"">
                            <blockquote>
                                <p class=""quote"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo repellendus nihil qui iure animi maxime consequuntur aliquid sed tempore, amet!</p>
                                <cite class=""author"">Elizabeth Anderson, Hostpital Patients</cite>
                            </blockquote>
                        </div>
            ");
                WriteLiteral(@"        </div>
                    <div class=""col-lg-4"">
                        <div class=""testimonial text-center"">
                            <img src=""images/person_2.jpg"" alt=""Image"" class=""img-fluid"">
                            <blockquote>
                                <p class=""quote"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo repellendus nihil qui iure animi maxime consequuntur aliquid sed tempore, amet!</p>
                                <cite class=""author"">Elizabeth Anderson, Hostpital Patients</cite>
                            </blockquote>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""testimonial text-center"">
                            <img src=""images/person_3.jpg"" alt=""Image"" class=""img-fluid"">
                            <blockquote>
                                <p class=""quote"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quo repellendus nihil ");
                WriteLiteral(@"qui iure animi maxime consequuntur aliquid sed tempore, amet!</p>
                                <cite class=""author"">Elizabeth Anderson, Hostpital Patients</cite>
                            </blockquote>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""site-section"">
            <div class=""container"">
                <div class=""row mb-5 justify-content-center"">
                    <div class=""col-lg-7 mx-auto text-center mb-5"">
                        <span class=""subheading"">Latest Blog</span>
                        <h2 class=""heading""><strong class=""text-primary"">News</strong> & Updates</h2>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""blog-entry"">
                            <a href=""#"" class=""d-block"">
                                <img src=""images/img_1.jpg"" alt=""Image"" clas");
                WriteLiteral(@"s=""img-fluid"">
                            </a>
                            <div class=""post-meta d-flex justify-content-center"">
                                <span>
                                    <span class=""icon-calendar""></span>
                                    <span>23 Jul</span>
                                </span>
                                <span>
                                    <span class=""icon-user""></span>
                                    <span>Admin</span>
                                </span>
                                <span>
                                    <span class=""icon-comment""></span>
                                    <span>2 Comments</span>
                                </span>
                            </div>
                            <h2><a href=""#"">We're Providing the Quality Care</a></h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. At, laudantium.</p>
                        </d");
                WriteLiteral(@"iv>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""blog-entry"">
                            <a href=""#"" class=""d-block"">
                                <img src=""images/img_2.jpg"" alt=""Image"" class=""img-fluid"">
                            </a>
                            <div class=""post-meta d-flex justify-content-center"">
                                <span>
                                    <span class=""icon-calendar""></span>
                                    <span>23 Jul</span>
                                </span>
                                <span>
                                    <span class=""icon-user""></span>
                                    <span>Admin</span>
                                </span>
                                <span>
                                    <span class=""icon-comment""></span>
                                    <span>2 Comments</span>
                                </span>");
                WriteLiteral(@"
                            </div>
                            <h2><a href=""#"">We're Providing the Quality Care</a></h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. At, laudantium.</p>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""blog-entry"">
                            <a href=""#"" class=""d-block"">
                                <img src=""images/img_3.jpg"" alt=""Image"" class=""img-fluid"">
                            </a>
                            <div class=""post-meta d-flex justify-content-center"">
                                <span>
                                    <span class=""icon-calendar""></span>
                                    <span>23 Jul</span>
                                </span>
                                <span>
                                    <span class=""icon-user""></span>
                                    <span>Admin</");
                WriteLiteral(@"span>
                                </span>
                                <span>
                                    <span class=""icon-comment""></span>
                                    <span>2 Comments</span>
                                </span>
                            </div>
                            <h2><a href=""#"">We're Providing the Quality Care</a></h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. At, laudantium.</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <footer class=""site-footer bg-primary"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3"">
                        <h2 class=""footer-heading mb-4"">Departments</h2>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"">X-Ray</a></li>
                            <li><a href=""#"">Children C");
                WriteLiteral(@"are</a></li>
                            <li><a href=""#"">Eye Treatment</a></li>
                            <li><a href=""#"">Nose Treatment</a></li>
                            <li><a href=""#"">Surgery</a></li>
                        </ul>
                    </div>
                    <div class=""col-lg-3"">
                        <h2 class=""footer-heading mb-4"">Our Services</h2>
                        <ul class=""list-unstyled"">
                            <li><a href=""#"">X-Ray</a></li>
                            <li><a href=""#"">Children Care</a></li>
                            <li><a href=""#"">Eye Treatment</a></li>
                            <li><a href=""#"">Nose Treatment</a></li>
                            <li><a href=""#"">Surgery</a></li>
                        </ul>
                    </div>
                    <div class=""col-lg-3"">
                        <h2 class=""footer-heading mb-4"">Navigation</h2>
                        <ul class=""list-unstyled"">
                          ");
                WriteLiteral(@"  <li><a href=""#"">Home</a></li>
                            <li><a href=""#"">About us</a></li>
                            <li><a href=""#"">Customer Care</a></li>
                            <li><a href=""#"">Privacy</a></li>
                            <li><a href=""#"">Terms</a></li>
                        </ul>
                    </div>
                    <div class=""col-lg-3"">
                        <h2 class=""footer-heading mb-4"">Social</h2>
                        <div class=""social mb-5"">
                            <a href=""#""");
                BeginWriteAttribute("class", " class=\"", 22163, "\"", 22171, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"icon-facebook\"></span></a>\r\n                            <a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 22253, "\"", 22261, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"icon-twitter\"></span></a>\r\n                            <a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 22342, "\"", 22350, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"icon-linkedin\"></span></a>\r\n                            <a href=\"#\"");
                BeginWriteAttribute("class", " class=\"", 22432, "\"", 22440, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"icon-instagram\"></span></a>\r\n                        </div>\r\n\r\n\r\n                        <h2 class=\"footer-heading mb-4\">Subscribe Newsletter</h2>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76bdf5cdc21b13b7b32f78c31a318b28318d699a31609", async() => {
                    WriteLiteral(@"
                            <div class=""input-group mb-3"">
                                <input type=""text"" class=""form-control  bg-transparent"" placeholder=""Enter Email"" aria-label=""Enter Email"" aria-describedby=""button-addon2"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-white text-black"" type=""button"" id=""button-addon2"">Send</button>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""row pt-5 mt-5 text-center"">
                    <div class=""col-md-12"">
                        <div class=""border-top pt-5"">
                            <p class=""copyright"">
                                <small>
                                    <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                                    Copyright &copy;
                                    <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""icon-heart text-danger"" aria-hidden=""true""></i> by <a href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                                    <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                                </small>
                            </p>

                        </div>
                    </div>

             ");
                WriteLiteral(@"   </div>
            </div>
        </footer>

    </div> <!-- .site-wrap -->

    <script src=""js/jquery-3.3.1.min.js""></script>
    <script src=""js/jquery-ui.js""></script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/jquery.countdown.min.js""></script>
    <script src=""js/jquery.easing.1.3.js""></script>
    <script src=""js/aos.js""></script>
    <script src=""js/jquery.fancybox.min.js""></script>
    <script src=""js/jquery.sticky.js""></script>
    <script src=""js/isotope.pkgd.min.js""></script>


    <script src=""js/main.js""></script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
