import { createApp } from 'vue'
import { router } from './router';
import App from './App.vue'
import {BootstrapVue3, BToastPlugin} from 'bootstrap-vue-3'
import Antd from 'ant-design-vue';
import 'ant-design-vue/dist/reset.css';
import VueSelect from 'vue3-select2-component'
import VCalendar from 'v-calendar';
import VueFeather from 'vue-feather';
import DatePicker from 'vue3-datepicker';
import 'vue3-datepicker/dist/vue3-datepicker.css';
import VueApexCharts from "vue3-apexcharts";
import Vue3Autocounter from 'vue3-autocounter';
import VueTelInput from 'vue3-tel-input';
// plugins
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import '@fortawesome/fontawesome-free/css/fontawesome.min.css';
import '@fortawesome/fontawesome-free/css/all.min.css';
import 'vue3-tel-input/dist/vue3-tel-input.css';

/***********************************************************************/
                     /* Frontend */
/***********************************************************************/

//Breadcrumb
import Breadcrumb from '@/components/frontend/breadcrumb/aboutus.vue'
import DoctorsSidebar from '@/views/frontend/layouts/doctorsidebar.vue'
import BlogSidebar from '@/views/frontend/layouts/blogsidebar.vue'
import PharmacyFilter from '@/views/frontend/layouts/pharmacyfilter.vue'
import Breadcrumb1 from '@/components/frontend/breadcrumb/breadcrumb1.vue'
import Mainmenu from '@/components/frontend/mainmenu.vue'
import Mainnav from '@/components/frontend/mainnav.vue'
import Profilewidget from '@/components/frontend/profilewidget.vue'


//pages
import Header from '@/views/frontend/layouts/header.vue'
import HeaderTwo from  '@/views/frontend/layouts/headertwo.vue'
import Headerinfo from '@/views/frontend/layouts/header-info.vue'
import Cursor from '@/views/frontend/layouts/cursor.vue'
import Scrolltotop from '@/views/frontend/layouts/scrolltotop.vue'
import ProfileSidebar from '@/views/frontend/layouts/profilesidebar.vue'

import Footer from '@/views/frontend/layouts/footer.vue'
import IndexBanner from '@/views/frontend/pages/home/indexbanner.vue'
import IndexDoctor from '@/views/frontend/pages/home/indexdoctor.vue'
import IndexWork from '@/views/frontend/pages/home/indexwork.vue'
import IndexApp from '@/views/frontend/pages/home/indexapp.vue'
import IndexTestimonial from '@/views/frontend/pages/home/indextestimonial.vue'
import IndexPartners from '@/views/frontend/pages/home/indexpartners.vue'
import IndexFooter from '@/views/frontend/pages/home/footer.vue'

import IndexTwoBanner from '@/views/frontend/pages/home2/indextwobanner.vue'
import IndexTwoClinic from '@/views/frontend/pages/home2/indextwoclinic.vue'
import IndexTwoPopular from '@/views/frontend/pages/home2/indextwopopular.vue'
import IndexTwoFeature from '@/views/frontend/pages/home2/indextwofeature.vue'
import IndexTwoBlog from '@/views/frontend/pages/home2/indextwoblog.vue'
import IndexTwoFooter from '@/views/frontend/pages/home2/footer.vue'

import IndexThreeBanner from '@/views/frontend/pages/home3/indexthreebanner.vue'
import IndexThreeDoctor from '@/views/frontend/pages/home3/indexthreedoctor.vue'
import IndexThreeClinic from '@/views/frontend/pages/home3/indexthreeclinic.vue'
import IndexThreeBlog from '@/views/frontend/pages/home3/indexthreeblog.vue'

import IndexFourBanner from '@/views/frontend/pages/home4/indexfourbanner.vue'
import IndexFourClinic from '@/views/frontend/pages/home4/indexfourclinic.vue'
import IndexFourBrowse from '@/views/frontend/pages/home4/indexfourbrowse.vue'
import IndexFourDoctors from '@/views/frontend/pages/home4/indexfourdoctors.vue'
import IndexFourBlog from '@/views/frontend/pages/home4/indexfourblog.vue'

import IndexFiveBanner from '@/views/frontend/pages/home5/indexfivebanner.vue'
import IndexFiveService from '@/views/frontend/pages/home5/indexfiveservice.vue'
import IndexFiveDoctor from '@/views/frontend/pages/home5/indexfivedoctor.vue'
import IndexFiveTestimonial from '@/views/frontend/pages/home5/indexfivetestimonial.vue'
import IndexFivePricing from '@/views/frontend/pages/home5/indexfivepricing.vue'
import IndexFiveFooter from '@/views/frontend/pages/home5/footer.vue'

import IndexSixBanner from '@/views/frontend/pages/home6/indexsixbanner.vue'
import IndexSixCenter from '@/views/frontend/pages/home6/indexsixcenter.vue'
import IndexSixClient from '@/views/frontend/pages/home6/indexsixclient.vue'
import IndexFiveStore from '@/views/frontend/pages/home6/indexfivestore.vue'
import EyeGlass from '@/views/frontend/pages/home6/eyeglass.vue'
import ComputerGlass from '@/views/frontend/pages/home6/computerglass.vue'
import KidsGlass from '@/views/frontend/pages/home6/kidsglass.vue'
import LenseGlass from '@/views/frontend/pages/home6/lenseglass.vue'
import SunGlass from '@/views/frontend/pages/home6/sunglass.vue'
import ReadingGlass from '@/views/frontend/pages/home6/readingglass.vue'
import IndexSixOffer from '@/views/frontend/pages/home6/indexsixoffer.vue'
import IndexSixBlog from '@/views/frontend/pages/home6/indexsixblog.vue'
import IndexSixTestimonial from '@/views/frontend/pages/home6/indexsixtestimonial.vue'
import IndexSixAppointment from '@/views/frontend/pages/home6/indexsixappointment.vue'
import IndexSixFooter from '@/views/frontend/pages/home6/footer.vue'

import Indexsevenbanner from '@/views/frontend/pages/home7/indexsevenbanner.vue'
import Indexsevenfeedback from '@/views/frontend/pages/home7/indexsevenfeedback.vue'
import Indexsevenfooter from '@/views/frontend/pages/home7/indexsevenfooter.vue'

import IndexEightBanner from '@/views/frontend/pages/home8/indexeightbanner.vue'
import IndexEightService from '@/views/frontend/pages/home8/indexeightservice'
import IndexEightChoose from '@/views/frontend/pages/home8/indexeightchoose.vue'
import IndexEightLatest from '@/views/frontend/pages/home8/indexeightlatest.vue'
import IndexEightFooter from '@/views/frontend/pages/home8/footer.vue'

import IndexNineBanner from '@/views/frontend/pages/home9/indexninebanner.vue'
import IndexNineTeam from '@/views/frontend/pages/home9/indexnineteam.vue'
import IndexNineBlog from '@/views/frontend/pages/home9/indexnineblog.vue'
import IndexNineChoose from '@/views/frontend/pages/home9/indexninechoose.vue'
import IndexNineContent from '@/views/frontend/pages/home9/indexninecontent.vue'
import IndexNineFooter from '@/views/frontend/pages/home9/footer.vue'

import Indextenbanner from '@/views/frontend/pages/home10/indextenbanner.vue'
import Indextendoctor from '@/views/frontend/pages/home10/indextendoctor.vue'
import Indextenpatient from '@/views/frontend/pages/home10/indextenpatient.vue'
import Indextenfooter from '@/views/frontend/pages/home10/indextenfooter.vue'

import indexelevenbanner from '@/views/frontend/pages/home11/indexelevenbanner.vue'
import IndexElevenTreatment from '@/views/frontend/pages/home11/indexeleventreatment.vue'
import IndexElevenServices from '@/views/frontend/pages/home11/indexelevenservices.vue'
import IndexElevenFacts from '@/views/frontend/pages/home11/indexelevenfacts.vue'
import IndexelevenPricing from '@/views/frontend/pages/home11/indexelevenpricing.vue'
import IndexElevenTestimonial from '@/views/frontend/pages/home11/indexeleventestimonial.vue'
import IndexElevenFooter from '@/views/frontend/pages/home11/footer.vue'

import IndexTwelveBanner from '@/views/frontend/pages/home12/indextwelvebanner.vue'
import TwelvePopular from '@/views/frontend/pages/home12/twelve-popular.vue'
import TwelveChest from '@/views/frontend/pages/home12/twelve-chest.vue'
import LabService from '@/views/frontend/pages/home12/lab-service.vue'
import TwelvePackages from '@/views/frontend/pages/home12/twelve-packages.vue'
import TwelveBest from '@/views/frontend/pages/home12/twelve-best.vue'
import BestCarousel from '@/views/frontend/pages/home12/best-carousel.vue'

import Home13_Banner from '@/views/frontend/pages/home13/home13-banner.vue'
import How_It_Work from '@/views/frontend/pages/home13/how-it-work.vue'
import Service_Section from '@/views/frontend/pages/home13/service-section.vue'
import Nurse_Section from '@/views/frontend/pages/home13/nurse-section.vue'
import Top_Nurse_Section from '@/views/frontend/pages/home13/top-nurse-section.vue'
import Work_Section from '@/views/frontend/pages/home13/work-section.vue'
import Blog_Section from '@/views/frontend/pages/home13/blog-section.vue'
import Pricing_Section from '@/views/frontend/pages/home13/pricing-section.vue'
import Faq_Section from '@/views/frontend/pages/home13/faq-section.vue'
import IndexFooter_Section from '@/views/frontend/pages/home13/footer-section.vue'
import BlogCarousel from '@/views/frontend/pages/home13/blog-carousel.vue'
import TwelveBook from '@/views/frontend/pages/home12/twelve-book.vue'
import TwelveFaq from '@/views/frontend/pages/home12/twelve-faq.vue'
import TwelvePricing from '@/views/frontend/pages/home12/twelve-pricing.vue'
import TwelveAbout from '@/views/frontend/pages/home12/twelve-about.vue'
import TwelveFooter from '@/views/frontend/pages/home12/twelve-footer.vue'

import BlogdetailComment from '@/views/frontend/pages/blog/blog-details-comment.vue'
import PharmacySlider from '@/views/frontend/pages/pharmacymenu/pharmacy-index/pharmacyslider.vue'
import OverviewContent from '@/views/frontend/pages/pharmacymenu/details/overview-content.vue'
import LocationContent from '@/views/frontend/pages/pharmacymenu/details/location-content.vue'
import ReviewContent from '@/views/frontend/pages/pharmacymenu/details/review-content.vue'
import BusinessContent from '@/views/frontend/pages/pharmacymenu/details/business-content.vue'
import productdetails from '@/views/frontend/pages/pharmacymenu/product-description/product-details.vue'
import productdescriptionsidebar from '@/views/frontend/pages/pharmacymenu/product-description/product-description-sidebar.vue'
import Medlifemedical from '@/views/frontend/pages/pharmacymenu/product/medlifemedical.vue'
import Cart_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/cart-section.vue'
import Top_Header from '@/views/frontend/pages/pharmacymenu/pharmacy-index/top-header.vue'
import Pharmacy_Banner from '@/views/frontend/pages/pharmacymenu/pharmacy-index/pharmacy-banner.vue'
import Welcome_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/welcome-section.vue'
import Deals_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/deals-section.vue'
import Categories_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/categories-section.vue'
import Seller_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/seller-section.vue'
import Feature_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/feature-section.vue'
import Product_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/product-section.vue'
import Coupon_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/coupon-section.vue'
import Best_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/best-section.vue'
import Trusted_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/trusted-section.vue'
import Review_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/review-section.vue'
import News_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/news-section.vue'
import App_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/app-section.vue'
import Footer_Section from '@/views/frontend/pages/pharmacymenu/pharmacy-index/footer-section.vue'

//Patient Pages
import PatientFooter from '@/views/frontend/pages/patients/patientfooter.vue'
import Searchlist from '@/views/frontend/pages/patients/searchdoctor/searchlist.vue'
import search2filter from '@/views/frontend/pages/patients/searchdoctor/search2/search2filter.vue'
import search2map from '@/views/frontend/pages/patients/searchdoctor/search2/search2map.vue'
import locations from '@/views/frontend/pages/patients/doctorprofile/locations.vue'
import overview from '@/views/frontend/pages/patients/doctorprofile/overview.vue'
import reviews from '@/views/frontend/pages/patients/doctorprofile/reviews.vue'
import businesshours from '@/views/frontend/pages/patients/doctorprofile/businesshours.vue'
import prescription from '@/views/frontend/pages/patients/dashboard/prescription.vue'
import patientappointment from '@/views/frontend/pages/patients/dashboard/patientappointment.vue'
import billing from '@/views/frontend/pages/patients/dashboard/billing.vue'
import medicalrecords from '@/views/frontend/pages/patients/dashboard/medical-records.vue'
import Chatleft from '@/views/frontend/pages/patients/chat/chatleft.vue'
import Chatright from '@/views/frontend/pages/patients/chat/chatright.vue'
import Doctorwidget from '@/views/frontend/pages/patients/doctors/maplist/doctorwidget.vue'
import medicalprescription from '@/views/frontend/pages/patients/medical-records/medicalprescription.vue'
import medical_records_table from '@/views/frontend/pages/patients/medical-records/medical-records-table.vue'
import medical_records_model from '@/views/frontend/pages/patients/medical-records/medical-records-model.vue'
import actions from '@/views/frontend/pages/patients/dependent/actions.vue'
import patientsaccounts1 from '@/views/frontend/pages/patients/accounts/accounts1.vue'
import patientsaccounts2 from '@/views/frontend/pages/patients/accounts/accounts2.vue'
import patientsaccounts3 from '@/views/frontend/pages/patients/accounts/accounts3.vue'
import graphfour from '@/views/frontend/pages/patients/dashboard/graphfour.vue'
import GraphOne from '@/views/frontend/pages/patients/dashboard/graphone.vue'
import GraphTwo from '@/views/frontend/pages/patients/dashboard/graphtwo.vue'
import GraphThree from '@/views/frontend/pages/patients/dashboard/graphthree.vue'

import DoctorSidebar from '@/views/frontend/layouts/doctorsidebar.vue'
import ScheduleSunday from '@/views/frontend/pages/doctors/scheduletiming/schedule-sunday.vue'
import ScheduleMonday from '@/views/frontend/pages/doctors/scheduletiming/schedule-monday.vue'
import ScheduleTuesday from '@/views/frontend/pages/doctors/scheduletiming/schedule-tuesday.vue'
import ScheduleWednesday from '@/views/frontend/pages/doctors/scheduletiming/schedule-wednesday.vue'
import ScheduleThursday from '@/views/frontend/pages/doctors/scheduletiming/schedule-thursday.vue'
import ScheduleFriday from '@/views/frontend/pages/doctors/scheduletiming/schedule-friday.vue'
import ScheduleSaturday from '@/views/frontend/pages/doctors/scheduletiming/schedule-saturday.vue'
import Dappointment from '@/views/frontend/pages/doctors/patient-profile/dappointment.vue'
import Dmedicalrecords from '@/views/frontend/pages/doctors/patient-profile/dmedicalrecords.vue'
import Dprescription from '@/views/frontend/pages/doctors/patient-profile/dprescription.vue'
import Dbilling from '@/views/frontend/pages/doctors/dbilling.vue'
import DoctorChatright from '@/views/frontend/pages/doctors/chat/chat-right.vue'
import DoctorChatleft from '@/views/frontend/pages/doctors/chat/chat-left.vue'
import DoctorChatModel from '@/views/frontend/pages/doctors/chat/chat-model.vue'
import DoctorProfileSettings1 from '@/views/frontend/pages/doctors/profile-settings/doctorprofile-settings1.vue'
import DoctorProfileSettings2 from '@/views/frontend/pages/doctors/profile-settings/doctorprofile-settings2.vue'
import DoctorModel from '@/views/frontend/pages/doctors/doctorblog/doctormodel.vue'
import EditPrescription from '@/views/frontend/pages/doctors/edit-prescription1.vue'
import Accounts1 from '@/views/frontend/pages/doctors/accounts1.vue'
import Accounts2 from '@/views/frontend/pages/doctors/accounts2.vue'
import Accounts3 from '@/views/frontend/pages/doctors/accounts3.vue'
import Experience from '@/views/frontend/pages/doctors/profile-settings/experience.vue'
import Awards from '@/views/frontend/pages/doctors/profile-settings/awards.vue'
import Memberships from '@/views/frontend/pages/doctors/profile-settings/memberships.vue'
import Registrations from '@/views/frontend/pages/doctors/profile-settings/registrations.vue'
import Addslot from '@/views/frontend/pages/doctors/scheduletiming/addslot.vue'
import Editslot from '@/views/frontend/pages/doctors/scheduletiming/editslot.vue'
import OnBoardingSidebar from '@/views/frontend/pages/onboard/onboarding-sidebar.vue'
import OnBoardingSlider from '@/views/frontend/pages/onboard/onboarding-slider.vue'

/***********************************************************************/
                      /*  Admin */
/***********************************************************************/

//Admin Components

import AdminHeader from '@/views/admin/layouts/adminheader.vue'
import AdminSidebar from '@/views/admin/layouts/adminsidebar.vue'

//Admin Breadcrumb
import adminBreadcrumb from '@/components/admin/breadcrumb/adminbreadcrumb.vue'
import adminBreadcrumb1 from '@/components/admin/breadcrumb/adminbreadcrumb1.vue'
import adminBreadcrumb2 from '@/components/admin/breadcrumb/adminbreadcrumb2.vue'
import adminBreadcrumb3 from '@/components/admin/breadcrumb/adminbreadcrumb3.vue'
import adminBreadcrumb4 from '@/components/admin/breadcrumb/adminbreadcrumb4.vue'
import AdminDelete from '@/components/admin/admindelete.vue'
import Tablecontent from '@/views/admin/pages/tables/tablecontent.vue'



/***********************************************************************/
                      /*  Pharmacy */
/***********************************************************************/

//pharmacy breadcrumb
import PharmacyBreadCrumb from '@/components/pharmacy/breadcrumb/pharmacybreadcrumb.vue'
import PharmacyBreadCrumb1 from '@/components/pharmacy/breadcrumb/pharmacybreadcrumb1.vue'
import PharmacyBreadCrumb2 from '@/components/pharmacy/breadcrumb/pharmacybreadcrumb2.vue'
//pharmacy model
import pharmacymodel from '@/components/pharmacy/model/pharmacymodel.vue'
import PharmacyDelete from '@/components/pharmacy/pharmacydelete.vue'

//pharmacy components
import PharmacyHeader from '@/views/pharmacy/layouts/pharmacyheader.vue'
import PharmacySidebar from '@/views/pharmacy/layouts/pharmacysidebar.vue'


const app = createApp(App);

// Breadcrumb
app.component('breadcrumb',Breadcrumb)
app.component('breadcrumb1',Breadcrumb1)
app.component('doctors-sidebar',DoctorsSidebar)
app.component('blogsidebar',BlogSidebar)
app.component('mainmenu',Mainmenu)
app.component('mainnav',Mainnav)
app.component('profilewidget',Profilewidget)


//pages
app.component('layoutheader', Header)
app.component('layoutheadertwo',HeaderTwo)
app.component('headerinfo',Headerinfo)
app.component('cursor',Cursor)
app.component('scrolltotop',Scrolltotop)
app.component('footerindex',Footer)
app.component('indexbanner',IndexBanner)
app.component('indexdoctor',IndexDoctor)
app.component('indexwork', IndexWork)
app.component('indexapp', IndexApp)
app.component('indextestimonial',IndexTestimonial)
app.component('indexpartners',IndexPartners)
app.component('indexfooter',IndexFooter)
app.component('indextwobanner',IndexTwoBanner)
app.component('indextwoclinic',IndexTwoClinic)
app.component('indextwopopular',IndexTwoPopular)
app.component('indextwofeature',IndexTwoFeature)
app.component('indextwoblog',IndexTwoBlog)
app.component('indextwofooter', IndexTwoFooter)
app.component('indexthreebanner',IndexThreeBanner)
app.component('indexthreedoctor',IndexThreeDoctor)
app.component('indexthreeclinic',IndexThreeClinic)
app.component('indexthreeblog',IndexThreeBlog)
app.component('indexfourbanner', IndexFourBanner)
app.component('indexfourclinic',IndexFourClinic)
app.component('indexfourbrowse',IndexFourBrowse)
app.component('indexfourdoctors',IndexFourDoctors)
app.component('indexfourblog',IndexFourBlog)
app.component('indexfivebanner',IndexFiveBanner)
app.component('indexfiveservice',IndexFiveService)
app.component('indexfivedoctor',IndexFiveDoctor)
app.component('indexfivetestimonial',IndexFiveTestimonial)
app.component('indexfivepricing',IndexFivePricing)
app.component('indexfivefooter', IndexFiveFooter)
app.component('indexsixbanner',IndexSixBanner)
app.component('indexsixcenter',IndexSixCenter)
app.component('indexsixclient',IndexSixClient)
app.component('indexfivestore',IndexFiveStore)
app.component('eyeglass',EyeGlass)
app.component('computerglass',ComputerGlass)
app.component('kidsglass',KidsGlass)
app.component('lenseglass',LenseGlass)
app.component('sunglass',SunGlass)
app.component('readingglass',ReadingGlass)
app.component('indexsixoffer',IndexSixOffer)
app.component('indexsixblog',IndexSixBlog)
app.component('indexsixtestimonial',IndexSixTestimonial)
app.component('indexsixappointment', IndexSixAppointment)
app.component('indexsixfooter',IndexSixFooter)
app.component('indexeightbanner',IndexEightBanner)
app.component('indexeightservice',IndexEightService)
app.component('indexeightchoose',IndexEightChoose)
app.component('indexeightlatest',IndexEightLatest)
app.component('indexeightfooter',IndexEightFooter)
app.component('indexninebanner',IndexNineBanner)
app.component('indexnineteam',IndexNineTeam)
app.component('indexnineblog',IndexNineBlog)
app.component('indexninechoose',IndexNineChoose)
app.component('indexninecontent',IndexNineContent)
app.component('indexninefooter',IndexNineFooter)
app.component('indexelevenbanner',indexelevenbanner)
app.component('indexeleventreatment',IndexElevenTreatment)
app.component('indexelevenservices',IndexElevenServices)
app.component('indexelevenfacts',IndexElevenFacts)
app.component('indexelevenpricing',IndexelevenPricing)
app.component('indexeleventestimonial',IndexElevenTestimonial)
app.component('indexelevenfooter',IndexElevenFooter)
app.component('indextwelvebanner', IndexTwelveBanner)
app.component('twelve-popular', TwelvePopular)
app.component('twelve-chest', TwelveChest)
app.component('lab-service', LabService)
app.component('twelve-packages', TwelvePackages)
app.component('twelve-best', TwelveBest)
app.component('best-carousel', BestCarousel)
app.component('home13-banner',Home13_Banner)
app.component('how-it-work',How_It_Work)
app.component('service-section',Service_Section)
app.component('nurse-section',Nurse_Section)
app.component('top-nurse-section',Top_Nurse_Section)
app.component('work-section',Work_Section)
app.component('blog-section',Blog_Section)
app.component('pricing-section',Pricing_Section)
app.component('faq-section',Faq_Section)
app.component('indexfooter-section',IndexFooter_Section)
app.component('blog-carousel', BlogCarousel)
app.component('twelve-book', TwelveBook)
app.component('twelve-faq', TwelveFaq)
app.component('twelve-pricing', TwelvePricing)
app.component('twelve-about', TwelveAbout)
app.component('twelve-footer', TwelveFooter)


app.component('indexsevenbanner',Indexsevenbanner)
app.component('indexsevenfeedback',Indexsevenfeedback)
app.component('indexsevenfooter',Indexsevenfooter)

app.component('indextenbanner',Indextenbanner)
app.component('indextendoctor',Indextendoctor)
app.component('indextenpatient',Indextenpatient)
app.component('indextenfooter',Indextenfooter)

app.component('blogdetailscomment',BlogdetailComment)
app.component('pharmacyslider',PharmacySlider)
app.component('overview-content',OverviewContent)
app.component('location-content', LocationContent)
app.component('review-content', ReviewContent)
app.component('business-content',BusinessContent)
app.component('pharmacy-filter',PharmacyFilter)
app.component('medlifemedical',Medlifemedical)
app.component('productdescriptionsidebar',productdescriptionsidebar)
app.component('productdetails',productdetails)
app.component('cart-section',Cart_Section)
app.component('top-header',Top_Header)
app.component('pharmacy-banner',Pharmacy_Banner)
app.component('welcome-section',Welcome_Section)
app.component('deals-section',Deals_Section)
app.component('categories-section',Categories_Section)
app.component('seller-section',Seller_Section)
app.component('feature-section',Feature_Section)
app.component('product-section',Product_Section)
app.component('coupon-section',Coupon_Section)
app.component('best-section',Best_Section)
app.component('trusted-section',Trusted_Section)
app.component('review-section',Review_Section)
app.component('news-section',News_Section)
app.component('app-section',App_Section)
app.component('footer-section',Footer_Section)

//Patient pages
app.component('profilesidebar',ProfileSidebar)
app.component('patientfooter',PatientFooter)
app.component('searchlist',Searchlist)
app.component('search2filter',search2filter)
app.component('search2map',search2map)
app.component('locations',locations)
app.component('overview',overview)
app.component('reviews',reviews)
app.component('businesshours',businesshours)
app.component('patientappointment',patientappointment)
app.component('medicalrecords',medicalrecords)
app.component('billing',billing)
app.component('prescription',prescription)
app.component('chatright',Chatright)
app.component('chatleft',Chatleft)
app.component('doctorwidget',Doctorwidget)
app.component('medicalprescription',medicalprescription)
app.component('medical-records-table',medical_records_table)
app.component('medical-records-model',medical_records_model)
app.component('actions',actions)
app.component('patientsaccounts1',patientsaccounts1)
app.component('patientsaccounts2',patientsaccounts2)
app.component('patientsaccounts3',patientsaccounts3)
app.component('graphfour',graphfour)
app.component('graphone', GraphOne)
app.component('graphtwo', GraphTwo)
app.component('graphthree', GraphThree)
app.component('doctorsidebar',DoctorSidebar)
app.component('doctormodel',DoctorModel)
app.component('edit-prescription1',EditPrescription)
app.component('schedule-sunday',ScheduleSunday)
app.component('schedule-monday',ScheduleMonday)
app.component('schedule-tuesday',ScheduleTuesday)
app.component('schedule-wednesday',ScheduleWednesday)
app.component('schedule-thursday',ScheduleThursday)
app.component('schedule-friday',ScheduleFriday)
app.component('schedule-saturday',ScheduleSaturday)
app.component('accounts1',Accounts1)
app.component('accounts2',Accounts2)
app.component('accounts3',Accounts3)
app.component('experience',Experience)
app.component('awards',Awards)
app.component('memberships',Memberships)
app.component('registrations',Registrations)
app.component('addslot',Addslot)
app.component('editslot', Editslot)
app.component('dappointment',Dappointment)
app.component('dmedicalrecords',Dmedicalrecords) 
app.component('dprescription',Dprescription)
app.component('dbilling',Dbilling)
app.component('doctorprofile-settings1',DoctorProfileSettings1)
app.component('doctorprofile-settings2',DoctorProfileSettings2)


app.component('doctor-chat-left',DoctorChatleft)
app.component('doctor-chat-right',DoctorChatright)
app.component('doctor-chat-model', DoctorChatModel)

app.component('onboarding-sidebar', OnBoardingSidebar)
app.component('onboarding-slider', OnBoardingSlider)

 /*************************** Admin ****************************/
// Admin Breadcrumb
app.component('adminbreadcrumb',adminBreadcrumb)
app.component('adminbreadcrumb1',adminBreadcrumb1)
app.component('adminbreadcrumb2',adminBreadcrumb2)
app.component('adminbreadcrumb3',adminBreadcrumb3)
app.component('adminbreadcrumb4',adminBreadcrumb4)

app.component('adminheader',AdminHeader)
app.component('adminsidebar',AdminSidebar)
app.component('admindelete',AdminDelete)
app.component('tablecontent',Tablecontent)


 /*************************** Pharmacy ****************************/
 // Pharmacy Breadcrumb
app.component('pharmacybreadcrumb',PharmacyBreadCrumb)
app.component('pharmacybreadcrumb1',PharmacyBreadCrumb1)
app.component('pharmacybreadcrumb2',PharmacyBreadCrumb2)

//Model
app.component('pharmacymodel',pharmacymodel)

//pharmacy
app.component('pharmacyheader',PharmacyHeader)
app.component('pharmacysidebar',PharmacySidebar)

app.component('pharmacydelete', PharmacyDelete)


app.component('vue3-autocounter', Vue3Autocounter)
app.component('vue-select', VueSelect)
app.component(VueFeather.name, VueFeather)
app.component('datepicker', DatePicker)
app.use(VueApexCharts)
.use(VueTelInput)
.use(BootstrapVue3)
.use(BToastPlugin)
.use(Antd)
app.use(VCalendar, {})
app.use(router).mount('#app');
