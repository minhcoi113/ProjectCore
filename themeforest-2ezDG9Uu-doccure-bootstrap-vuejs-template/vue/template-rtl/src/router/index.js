import {createRouter, createWebHistory} from 'vue-router';

import Index from '@/views/frontend/pages/home/index.vue'
import IndexTwo from '@/views/frontend/pages/home2/index-2.vue'
import IndexThree from '@/views/frontend/pages/home3/index-3.vue'
import IndexFour from '@/views/frontend/pages/home4/index-4.vue'
import IndexFive from '@/views/frontend/pages/home5/index-5.vue'
import IndexSix from '@/views/frontend/pages/home6/index-6.vue'
import IndexEight from '@/views/frontend/pages/home8/index-8.vue'
import IndexNine from '@/views/frontend/pages/home9/index-9.vue'
import IndexEleven from '@/views/frontend/pages/home11/index-11.vue'
import IndexSeven from '@/views/frontend/pages/home7/index-7.vue'
import IndexTen from '@/views/frontend/pages/home10/index-10.vue'
import IndexTwelve from '@/views/frontend/pages/home12/index-12.vue'
import IndexThirteen from '@/views/frontend/pages/home13/index-13.vue'
import AboutUs from '@/views/frontend/pages/pages/about-us.vue'

import ContactUs from '@/views/frontend/pages/pages/contact-us.vue'
import VoiceCall from '@/views/frontend/pages/pages/call/voice-call.vue'
import VideoCall from '@/views/frontend/pages/pages/call/video-call.vue'
import Invoices from '@/views/frontend/pages/pages/invoices/invoices.vue'
import InvoiceView from '@/views/frontend/pages/pages/invoices/invoice-view.vue'
import LoginEmail from '@/views/frontend/pages/pages/authentication/login-email.vue'
import LoginPage from '@/views/frontend/pages/pages/authentication/login.vue'
import Mobileotp from '@/views/frontend/pages/pages/authentication/mobile-otp.vue'
import LoginPhone from '@/views/frontend/pages/pages/authentication/login-phone.vue'
import DoctorSignup from '@/views/frontend/pages/pages/authentication/doctor-signup.vue'
import PatientSignup from '@/views/frontend/pages/pages/authentication/patient-signup.vue'
import ForgotPassword from '@/views/frontend/pages/pages/authentication/forgot-password.vue'
import ForgotPasswordTwo from '@/views/frontend/pages/pages/authentication/forgot-password2.vue'
import LoginEmailOtp from '@/views/frontend/pages/pages/authentication/login-email-otp.vue'
import EmailOtp from '@/views/frontend/pages/pages/authentication/email-otp.vue'
import LoginPhoneOtp from '@/views/frontend/pages/pages/authentication/login-phone-otp.vue'
import Error404 from '@/views/frontend/pages/pages/errorpages/error-404.vue'
import Error500 from '@/views/frontend/pages/pages/errorpages/error-500.vue'
import BlankPage from '@/views/frontend/pages/pages/blank-page.vue'
import Pricing from '@/views/frontend/pages/pages/pricing.vue'
import Privacypolicy from '@/views/frontend/pages/pages/privacy-policy.vue'
import Maintenance from '@/views/frontend/pages/pages/maintenance.vue'
import ComingSoon from '@/views/frontend/pages/pages/coming-soon.vue'
import TermsCondition from '@/views/frontend/pages/pages/terms-condition.vue'
import BlogList from '@/views/frontend/pages/blog/blog-list.vue'
import FAQ from '@/views/frontend/pages/pages/faq.vue'
import BlogGrid from '@/views/frontend/pages/blog/blog-grid.vue'
import BlogDetails from '@/views/frontend/pages/blog/blog-details.vue'
import PharmacyIndex from '@/views/frontend/pages/pharmacymenu/pharmacy-index/pharmacy-index.vue'
import PharmacyDetails from '@/views/frontend/pages/pharmacymenu/details/pharmacy-details.vue'
import PharmacySearch from '@/views/frontend/pages/pharmacymenu/pharmacy-search.vue'
import ProductAll from '@/views/frontend/pages/pharmacymenu/product/product-all'
import Product_Description from '@/views/frontend/pages/pharmacymenu/product-description/product-description.vue'
import Cart from '@/views/frontend/pages/pharmacymenu/cart.vue'
import PaymentSuccess from '@/views/frontend/pages/pharmacymenu/payment-success.vue'
import Payment from '@/views/frontend/pages/pharmacymenu/payment.vue'
import PharmacyRegister from '@/views/frontend/pages/pharmacymenu/pharmacy-register.vue'
import ProductCheckout from '@/views/frontend/pages/pharmacymenu/product-checkout.vue'

import Change_Password from '@/views/frontend/pages/patients/change-password.vue'
import Profile_Settings from '@/views/frontend/pages/patients/profile-settings.vue'
import Chat from '@/views/frontend/pages/patients/chat/chat.vue'
import Favourites from '@/views/frontend/pages/patients/favourites.vue'
import Booking_Success from '@/views/frontend/pages/patients/booking-success.vue'
import Booking_Success_one from '@/views/frontend/pages/patients/booking-success-one.vue'
import Checkout from '@/views/frontend/pages/patients/checkout.vue'
import Paitentdetails from '@/views/frontend/pages/patients/patient-details.vue'
import Patient_Dashboard from '@/views/frontend/pages/patients/dashboard/patient-dashboard.vue'
import map_grid from '@/views/frontend/pages/patients/doctors/map-grid.vue'
import map_list from '@/views/frontend/pages/patients/doctors/maplist/map-list.vue'
import Search from '@/views/frontend/pages/patients/searchdoctor/search.vue'
import Search_2 from '@/views/frontend/pages/patients/searchdoctor/search2/search-2.vue'
import Booking from '@/views/frontend/pages/patients/booking/booking.vue'
import Booking_2 from '@/views/frontend/pages/patients/booking/booking-2.vue'
import Doctor_Profile from '@/views/frontend/pages/patients/doctorprofile/doctorprofile.vue'
import Doctor_Search_Grid from '@/views/frontend/pages/patients/searchdoctor/search2/doctor-search-grid.vue'
import Pharmacy_Register_Step1 from '@/views/frontend/pages/pharmacymenu/pharmacy-register-step1.vue'
import Pharmacy_Register_Step2 from '@/views/frontend/pages/pharmacymenu/pharmacy-register-step2.vue'
import Pharmacy_Register_Step3 from '@/views/frontend/pages/pharmacymenu/pharmacy-register-step3.vue'
import Medical_Details from '@/views/frontend/pages/patients/medical-details.vue'
import Medical_Records from '@/views/frontend/pages/patients/medical-records/medical-records.vue'
import Orders_List from '@/views/frontend/pages/patients/orders-list.vue'
import Dependent from '@/views/frontend/pages/patients/dependent/dependent.vue'
import Patient_Accounts from '@/views/frontend/pages/patients/accounts/accounts.vue'

//Doctor Pages
import Reviews from '@/views/frontend/pages/doctors/reviews.vue'
import DoctorDashBoard from '@/views/frontend/pages/doctors/doctor-dashboard.vue'
import DoctorRegister from '@/views/frontend/pages/doctors/doctor-register.vue'
import DoctorRegisterStep1 from '@/views/frontend/pages/doctors/doctor-register-step1.vue'
import DoctorRegisterStep2 from '@/views/frontend/pages/doctors/doctor-register-step2.vue'
import DoctorRegisterStep3 from '@/views/frontend/pages/doctors/doctor-register-step3.vue'
import Appointments from '@/views/frontend/pages/doctors/doctor-appointment.vue'
import PatientsList from '@/views/frontend/pages/doctors/patients-list.vue'
import DoctorPatientProfile from '@/views/frontend/pages/doctors/patient-profile/doctor-patientprofile.vue'
import AddPrescription from '@/views/frontend/pages/doctors/add-prescription.vue'
import AddBilling from '@/views/frontend/pages/doctors/add-billing.vue'
import Editbilling from '@/views/frontend/pages/doctors/edit-billing.vue'
import Frontcomponents from '@/views/frontend/pages/pages/components.vue'
import Signupsuccess from '@/views/frontend/pages/pages/signup-success.vue'
import FrontendSignup from '@/views/frontend/pages/pages/signup.vue'
import Consultation from '@/views/frontend/pages/pages/consultation.vue'
import ChatDoctor from '@/views/frontend/pages/doctors/chat/chat-doctor.vue'
import DoctorProfileSettings from '@/views/frontend/pages/doctors/profile-settings/doctorprofile-settings.vue'
import DoctorBlog from '@/views/frontend/pages/doctors/doctorblog/doctor-blog.vue'
import DoctorPendingBlog from '@/views/frontend/pages/doctors/doctorblog/doctor-pendingblog.vue'
import DoctorAddBlog from '@/views/frontend/pages/doctors/doctorblog/doctor-addblog.vue'
import DoctorEditlog from '@/views/frontend/pages/doctors/doctorblog/doctor-editblog.vue'
import EditPrescription from '@/views/frontend/pages/doctors/edit-prescription.vue'
import Accounts from '@/views/frontend/pages/doctors/accounts.vue'
import SocialMedia from '@/views/frontend/pages/doctors/social-media.vue'
import DoctorChangePassword from '@/views/frontend/pages/doctors/doctor-changepassword.vue'
import Register from '@/views/frontend/pages/doctors/register.vue'
import PatientRegisterstep1 from '@/views/frontend/pages/doctors/patient-register-step1.vue'
import PatientRegisterstep2 from '@/views/frontend/pages/doctors/patient-register-step2.vue'
import PatientRegisterstep3 from '@/views/frontend/pages/doctors/patient-register-step3.vue'
import PatientRegisterstep4 from '@/views/frontend/pages/doctors/patient-register-step4.vue'
import PatientRegisterstep5 from '@/views/frontend/pages/doctors/patient-register-step5.vue'
import ScheduleTimings from '@/views/frontend/pages/doctors/scheduletiming/schedule-timings.vue'
import AvailableTiming from '@/views/frontend/pages/doctors/scheduletiming/availabletiming.vue'
import OnboardingEmaill from '@/views/frontend/pages/onboard/onboarding-email.vue'
import OnboardingEmaillOtp from '@/views/frontend/pages/onboard/onboarding-email-otp.vue'
import OnboardingPhone from '@/views/frontend/pages/onboard/onboarding-phone.vue'
import OnboardingPhoneOtp from '@/views/frontend/pages/onboard/onboarding-phone-otp.vue'
import OnBoardingPassword from '@/views/frontend/pages/onboard/onboarding-password.vue'
import OnBoardingIdentity from '@/views/frontend/pages/onboard/onboarding-identity.vue'
import OnBoardingPersonalize from '@/views/frontend/pages/onboard/onboarding-personalize.vue'
import OnBoardingVerification from '@/views/frontend/pages/onboard/onboarding-verification.vue'
import OnBoardingPayments from '@/views/frontend/pages/onboard/onboarding-payments.vue'
import OnBoardingPreferences from '@/views/frontend/pages/onboard/onboarding-preferences.vue'
import OnBoardingAvailability from '@/views/frontend/pages/onboard/onboarding-availability.vue'
import OnBoardingConsultation from '@/views/frontend/pages/onboard/onboarding-consultation.vue'
import OnBoardingCost from '@/views/frontend/pages/onboard/onboarding-cost.vue'
import OnBoardingStepVerify from '@/views/frontend/pages/onboard/onboarding-email-step-2-verify.vue'
import OnBoardingLock from '@/views/frontend/pages/onboard/onboarding-lock.vue'
import OnBoardingVerifyAccount from '@/views/frontend/pages/onboard/onboarding-verify-account.vue'

/********* Admin ***********/

import AdminAppointmentList from '@/views/admin/pages/appointmentlist.vue'
import AdminProfile from '@/views/admin/pages/profile.vue'
import AdminSettings from '@/views/admin/pages/settings.vue'
import AdminLogin from '@/views/admin/pages/authentication/login.vue'
import AdminRegister from '@/views/admin/pages/authentication/register.vue'
import AdminForgot_Password from '@/views/admin/pages/authentication/forgot-password.vue'
import AdminLock_Screen from '@/views/admin/pages/authentication/lock-screen.vue'
import AdminError_404 from '@/views/admin/pages/error_pages/error-404.vue'
import AdminError_500 from '@/views/admin/pages/error_pages/error-500.vue'
import AdminComponents from '@/views/admin/pages/components.vue'
import AdminForm_Basic_Inputs from '@/views/admin/pages/forms/form-basic-inputs.vue'
import AdminForm_Horizontal from '@/views/admin/pages/forms/form-horizontal.vue'
import AdminForm_Input_Groups from '@/views/admin/pages/forms/form-input-groups.vue'
import AdminForm_Mask from '@/views/admin/pages/forms/form-mask.vue'
import AdminForm_Validation from '@/views/admin/pages/forms/form-validation.vue'
import AdminForm_Vertical from '@/views/admin/pages/forms/form-vertical.vue'
import AdminBlank_Page from '@/views/admin/pages/blank-page.vue'
import AdminSpecialities from '@/views/admin/pages/specialities.vue'
import AdminDoctor_List from '@/views/admin/pages/doctor-list.vue'
import AdminPatient_List from '@/views/admin/pages/patient-list.vue'
import AdminReviews from '@/views/admin/pages/reviews.vue'
import AdminTransactions_List from '@/views/admin/pages/transactions-list.vue'
import AdminInvoice_Report from '@/views/admin/pages/reports/invoice-report.vue'
import AdminInvoice from '@/views/admin/pages/invoice.vue'
import AdminData_Tables from '@/views/admin/pages/tables/data-tables.vue'
import AdminTables_Basic from '@/views/admin/pages/tables/tables-basic.vue'
import AdminIndex from '@/views/admin/pages/dashboard/index.vue'
import AdminCalendar from '@/views/admin/pages/calendar.vue'

/****************** Pharmacy ******************/

//pharmacy components
import Pharmacyindex from '@/views/pharmacy/pages/dashboard/pharmacyindex.vue'
import PharmacySetting from '@/views/pharmacy/pages/pharmacysetting.vue'
import PharmacyProfile from '@/views/pharmacy/pages/pharmacyprofile.vue'
import PharmacyAddProduct from '@/views/pharmacy/pages/pharmacyaddproduct.vue'
import PharmacyAddPurchase from '@/views/pharmacy/pages/pharmacyaddpurchase.vue'
import PharmacyAddSupplier from '@/views/pharmacy/pages/pharmacyaddsupplier.vue'
import PharmacyProducts from '@/views/pharmacy/pages/pharmacyproducts.vue'
import PharmacyExpired from '@/views/pharmacy/pages/pharmacyexpired.vue'
import PharmacyCategories from '@/views/pharmacy/pages/pharmacycategories.vue'
import PharmacyInvoiceReport from '@/views/pharmacy/pages/pharmacyinvoicereport.vue'
import PharmacyOrder from '@/views/pharmacy/pages/pharmacyorder.vue'
import PharmacyOutstock from '@/views/pharmacy/pages/pharmacyoutstock.vue'
import PharmacyPurchase from '@/views/pharmacy/pages/pharmacypurchase.vue'
import  PharmacySales from '@/views/pharmacy/pages/pharmacysales.vue'
import PharmacyTransaction from '@/views/pharmacy/pages/pharmacytransaction.vue'
import PharmacySupplier from '@/views/pharmacy/pages/pharmacysupplier.vue'
import PharmacyEditProduct from '@/views/pharmacy/pages/pharmacyeditproduct.vue'
import PharmacyEditPurchase from '@/views/pharmacy/pages/pharmacyeditpurchase.vue'
import PharmacyEditSupplier from '@/views/pharmacy/pages/pharmacyeditsupplier.vue'
import PharmacyInvoice from '@/views/pharmacy/pages/pharmacyinvoice.vue'
import PharmacyLogin from '@/views/pharmacy/pages/pharmacylogin.vue'
import Pharmacyforgotpassword from '@/views/pharmacy/pages/pharmacyforgotpassword.vue'
import Pharmacyregister from '@/views/pharmacy/pages/pharmacyregister.vue'


const routes = [

/**************** Frontend  *************/
    {
        path: '/',
        name: 'index',
        component: Index,
    },
    {
        path: '/index-2',
        name: 'index-2',
        component: IndexTwo,
        meta: {
            headerClass: 'header-two',
       }
    },
    {
        path: '/index-3',
        name: 'index-3',
        component: IndexThree,
        meta: {
            headerClass: 'header-eight',
       }
    },
    {
        path: '/index-4',
        name: 'index-4',
        component: IndexFour,
        meta: {
            headerClass: 'custom',
            headerNavClass: 'no-border',
            headerMainNavClass: 'white-font',
       }
    },
    {
        path: '/index-5',
        name: 'index-5',
        component: IndexFive,
        meta: {
            headerClass: 'header-ten',
       }
    },
    {
        path: '/index-6',
        name: 'index-6',
        component: IndexSix,
        meta: {
            headerClass: 'header-eleven',
       }
    },
    {
        path: '/index-8',
        name: 'index-8',
        component: IndexEight,
        meta: {
            headerClass: 'header-fourteen header-twelve',
       }
    },
    {
        path: '/index-9',
        name: 'index-9',
        component: IndexNine
    },
    {
        path: '/index-11',
        name: 'index-11',
        component: IndexEleven,
        meta: {
            headerClass: 'header-fourteen header-sixteen',
       }
    },
    {
        path: '/index-12',
        name: 'index-12',
        component: IndexTwelve,
        meta: {
            headerClass: 'header-fourteen header-twelve header-thirteen',
       }
    },
    {
        path: '/index-7',
        name: 'index-7',
        component: IndexSeven,
        meta: {
            headerClass: 'header-fourteen header-twelve',
       }
    },
    {
        path: '/index-10',
        name: 'index-10',
        component: IndexTen,
        meta: {
            headerClass: 'header-fourteen',
       }
    },
    {
        path: '/index-12',
        name: 'index-12',
        component: IndexTwelve,
        meta: {
            headerClass: 'header-fourteen header-twelve header-thirteen',
       }
    },
{
        path: '/index-13',
        name: 'index-13',
        component: IndexThirteen,
        meta: {
            headerClass: 'header-ten home-care-header',
       }
    },
    {
        path: '/about-us',
        name: 'about-us',
        component: AboutUs
    },
    {
        path: '/contact-us',
        name: 'contact-us',
        component: ContactUs
    },
    {
        path: '/voice-call',
        name: 'voice-call',
        component: VoiceCall
    },
    {
        path: '/video-call',
        name: 'video-call',
        component: VideoCall
    },
    {
        path: '/invoices',
        name: 'invoices',
        component: Invoices
    },
    {
        path: '/invoice-view',
        name: 'invoice-view',
        component: InvoiceView
    },
    {
        path: '/login',
        name: 'login',
        component: LoginPage
    },{
        path: '/mobile-otp',
        name: 'mobile-otp',
        component: Mobileotp
    },
    {
        path: '/login-email',
        name: 'login-email',
        component: LoginEmail
    },
    {
        path: '/login-phone',
        name: 'login-phone',
        component: LoginPhone
    },
    {
        path: '/doctor-signup',
        name: 'doctor-signup',
        component: DoctorSignup
    },
    {
        path: '/patient-signup',
        name: 'patient-signup',
        component: PatientSignup
    },
    {
        path: '/forgot-password',
        name: 'forgot-password',
        component: ForgotPassword
    },
    {
        path: '/forgot-password2',
        name: 'forgot-password2',
        component: ForgotPasswordTwo
    },
    {
        path: '/login-email-otp',
        name: 'login-email-otp',
        component: LoginEmailOtp
    },
    {
        path: '/email-otp',
        name: 'email-otp',
        component: EmailOtp
    },
    {
        path: '/login-phone-otp',
        name: 'login-phone-otp',
        component: LoginPhoneOtp
    },
    {
        path: '/error-404',
        name: 'error-404',
        component: Error404
    },
    {
        path: '/error-500',
        name: 'error-500',
        component: Error500
    },
    {
        path: '/blank-page',
        name: 'blank-page',
        component: BlankPage
    },
    {
        path: '/pricing',
        name: 'pricing',
        component: Pricing
    },
    {
        path: '/privacy-policy',
        name: 'privacy-policy',
        component: Privacypolicy
    },
    {
        path: '/maintenance',
        name: 'maintenance',
        component: Maintenance
    },
    {
        path: '/coming-soon',
        name: 'coming-soon',
        component: ComingSoon
    },
    {
        path: '/terms-condition',
        name: 'terms-condition',
        component: TermsCondition
    },
    {
        path: '/faq',
        name: 'faq',
        component: FAQ
    },
    {
        path: '/blog-list',
        name: 'blog-list',
        component: BlogList
    },
    {
        path: '/blog-grid',
        name: 'blog-grid',
        component: BlogGrid
    },
    {
        path: '/blog-details',
        name: 'blog-details',
        component: BlogDetails
    },
    {
        path: '/pharmacy-index',
        name: 'pharmacy-index',
        component: PharmacyIndex
    },
    {
        path: '/pharmacy-details',
        name: 'pharmacy-details',
        component: PharmacyDetails
    },
    {
        path: '/pharmacy-search',
        name: 'pharmacy-search',
        component: PharmacySearch
    },
    {
        path: '/product-all',
        name: 'product-all',
        component: ProductAll
    },
    {
        path: '/product-description',
        name: 'product-description',
        component: Product_Description
    },
    {
        path: '/cart',
        name: 'cart',
        component: Cart
    },
    {
        path: '/payment-success',
        name: 'payment-success',
        component: PaymentSuccess
    },
    {
        path: '/payment',
        name: 'payment',
        component: Payment
    },
    {
        path: '/pharmacy-register',
        name: 'pharmacy-register',
        component: PharmacyRegister
    },
    {
        path: '/product-checkout',
        name: 'product-checkout',
        component: ProductCheckout
    },

    {
        path: '/change-password',
        name: 'change-password',
        component: Change_Password
    },

    {
        path: '/profile-settings',
        name: 'profile-settings',
        component: Profile_Settings
    },

    {
        path: '/chat',
        name: 'chat',
        component: Chat
    },
    {
        path: '/favourites',
        name: 'favourites',
        component: Favourites
    },
    {
        path: '/booking-success',
        name: 'booking-success',
        component: Booking_Success
    },
    {
        path: '/booking-success-one',
        name: 'booking-success-one',
        component: Booking_Success_one
    },
    {
        path: '/checkout',
        name: 'checkout',
        component: Checkout
    },
    {
        path: '/patient-details',
        name: 'patient-details',
        component: Paitentdetails
    },
    {
        path: '/patient-dashboard',
        name: 'patient-dashboard',
        component: Patient_Dashboard
    },
    {
        path: '/map-grid',
        name: 'map-grid',
        component: map_grid
    },
    {
        path: '/map-list',
        name: 'map-list',
        component: map_list
    },
    {
        path: '/search',
        name: 'search',
        component: Search
    },
    {
        path: '/search-2',
        name: 'search-2',
        component: Search_2
    },
    {
        path: '/booking',
        name: 'booking',
        component: Booking
    },
    {
        path: '/doctor-profile',
        name: 'doctor-profile',
        component: Doctor_Profile
    },
    {
        path: '/booking-2',
        name: 'booking-2',
        component: Booking_2
    },
    {
        path: '/reviews',
        name: 'reviews',
        component: Reviews
    },
    {
        path: '/doctor-search-grid',
        name: 'doctor-search-grid',
        component: Doctor_Search_Grid
    },
    {
        path: '/pharmacy-register-step1',
        name: 'pharmacy-register-step1',
        component: Pharmacy_Register_Step1
    },
    {
        path: '/pharmacy-register-step2',
        name: 'pharmacy-register-step2',
        component: Pharmacy_Register_Step2
    },
    {
        path: '/pharmacy-register-step3',
        name: 'pharmacy-register-step3',
        component: Pharmacy_Register_Step3
    },
    {
        path: '/medical-details',
        name: 'medical-details',
        component: Medical_Details
    },
    {
        path: '/medical-records',
        name: 'medical-records',
        component: Medical_Records
    },
    {
        path: '/orders-list',
        name: 'orders-list',
        component: Orders_List
    },
    {
        path: '/dependent',
        name: 'dependent',
        component: Dependent
    },
    {
        path: '/patient-accounts',
        name: 'patient-accounts',
        component: Patient_Accounts
    },
    

    {
        path: '/doctor-dashboard',
        name: 'doctor-dashboard',
        component: DoctorDashBoard
    },
    {
        path: '/doctor-register',
        name: 'doctor-register',
        component: DoctorRegister
    },
    {
        path: '/doctor-register-step1',
        name: 'doctor-register-step1',
        component: DoctorRegisterStep1
    },
    {
        path: '/doctor-register-step2',
        name: 'doctor-register-step2',
        component: DoctorRegisterStep2
    },
    {
        path: '/doctor-register-step3',
        name: 'doctor-register-step3',
        component: DoctorRegisterStep3
    },
    {
        path: '/appointments',
        name: 'appointments',
        component: Appointments 
    },
    {
        path: '/schedule-timings',
        name: 'schedule-timings',
        component: ScheduleTimings 
    },
    {
        path: '/my-patients',
        name: 'my-patients',
        component: PatientsList
    },
    {
        path: '/patient-profile',
        name: 'patient-profile',
        component: DoctorPatientProfile
    },
    {
        path: '/add-prescription',
        name: 'add-prescription',
        component: AddPrescription
    },
    {
        path: '/add-billing',
        name: 'add-billing',
        component: AddBilling
    },
    {
        path: '/edit-billing',
        name: 'edit-billing',
        component: Editbilling
    },
    {
        path: '/components',
        name: 'components',
        component: Frontcomponents
    }, 
    {
        path: '/signup-success',
        name: 'signup-success',
        component: Signupsuccess
    },
    {
        path: '/signup',
        name: 'signup',
        component: FrontendSignup
    },
    {
        path: '/consultation',
        name: 'consultation',
        component: Consultation
    },
    {
        path: '/chat-doctor',
        name: 'chat-doctor',
        component: ChatDoctor
    },
    {
        path: '/doctor-profile-settings',
        name: 'doctor-profile-settings',
        component: DoctorProfileSettings
    },
    {
        path: '/doctor-blog',
        name: 'doctor-blog',
        component: DoctorBlog
    },
    {
        path: '/doctor-pending-blog',
        name: 'doctor-pending-blog',
        component: DoctorPendingBlog
    },
    {
        path: '/doctor-add-blog',
        name: 'doctor-add-blog',
        component: DoctorAddBlog
    },
    {
        path: '/edit-blog',
        name: 'edit-blog',
        component: DoctorEditlog
    },
    {
        path: '/edit-prescription',
        name: 'edit-prescription',
        component: EditPrescription
    },
    {
        path: '/available-timings',
        name: 'available-timings',
        component: AvailableTiming
    },
    {
        path: '/accounts',
        name: 'accounts',
        component: Accounts
    },
    {
        path: '/social-media',
        name: 'social-media',
        component: SocialMedia
    },
    {
        path: '/doctor-change-password',
        name: 'doctor-changepassword',
        component: DoctorChangePassword
    },
    {
        path: '/register',
        name: 'register',
        component: Register
    },
    {
        path: '/patient-register-step1',
        name: 'patient-register-step1',
        component: PatientRegisterstep1
    },
    {
        path: '/patient-register-step2',
        name: 'patient-register-step2',
        component: PatientRegisterstep2
    },
    {
        path: '/patient-register-step3',
        name: 'patient-register-step3',
        component: PatientRegisterstep3
    },
    {
        path: '/patient-register-step4',
        name: 'patient-register-step4',
        component: PatientRegisterstep4
    },
    {
        path: '/patient-register-step5',
        name: 'patient-register-step5',
        component: PatientRegisterstep5
    },
    {
        path: '/onboarding-email',
        name: '/onboarding-email',
        component: OnboardingEmaill
    },
    {
        path: '/onboarding-email-otp',
        name: '/onboarding-email-otp',
        component: OnboardingEmaillOtp
    },
    {
        path: '/onboarding-phone',
        name: '/onboarding-phone',
        component: OnboardingPhone
    },
    {
        path: '/onboarding-phone-otp',
        name: '/onboarding-phone-otp',
        component: OnboardingPhoneOtp
    },
    {
        path: '/onboarding-password',
        name: '/onboarding-password',
        component: OnBoardingPassword
    },
    {
        path: '/onboarding-identity',
        name: '/onboarding-identity',
        component: OnBoardingIdentity
    },
    {
        path: '/onboarding-personalize',
        name: '/onboarding-personalize',
        component: OnBoardingPersonalize
    },
    {
        path: '/onboarding-verification',
        name: '/onboarding-verification',
        component: OnBoardingVerification
    },
    {
        path: '/onboarding-payments',
        name: '/onboarding-payments',
        component: OnBoardingPayments
    },
    {
        path: '/onboarding-preferences',
        name: '/onboarding-preferences',
        component: OnBoardingPreferences
    },
    {
        path: '/onboarding-availability',
        name: '/onboarding-availability',
        component: OnBoardingAvailability
    },
    {
        path: '/onboarding-consultation',
        name: '/onboarding-consultation',
        component: OnBoardingConsultation
    },
    {
        path: '/onboarding-cost',
        name: '/onboarding-cost',
        component: OnBoardingCost
    },
    {
        path: '/onboarding-email-step-2-verify',
        name: '/onboarding-email-step-2-verify',
        component: OnBoardingStepVerify
    },
    {
        path: '/onboarding-lock',
        name: '/onboarding-lock',
        component: OnBoardingLock
    },
    {
        path: '/onboarding-verify-account',
        name: '/onboarding-verify-account',
        component: OnBoardingVerifyAccount
    },

    /**************** Admin  *************/
    {
        path: '/admin/appointment-list',
        name: 'admin/appointment-list',
        component: AdminAppointmentList
    },

    {
        path: '/admin/profile',
        name: 'admin/profile',
        component: AdminProfile
    },

    {
        path: '/admin/settings',
        name: 'admin/settings',
        component: AdminSettings
    },

    {
        path: '/admin/login',
        name: 'admin/login',
        component: AdminLogin
    },

    {
        path: '/admin/register',
        name: 'admin/register',
        component: AdminRegister
    },

    {
        path: '/admin/forgot-password',
        name: 'admin/forgot-paasword',
        component: AdminForgot_Password
    },
    
    {
        path: '/admin/lock-screen',
        name: 'admin/lock-screen',
        component: AdminLock_Screen
    },

    {
        path: '/admin/error-404',
        name: 'admin/error-404',
        component: AdminError_404
    },

    {
        path: '/admin/error-500',
        name: 'admin/error-500',
        component: AdminError_500
    },

    {
        path: '/admin/components',
        name: 'admin/components',
        component: AdminComponents
    },

    {
        path: '/admin/form-basic-inputs',
        name: 'admin/form-basic-inputs',
        component: AdminForm_Basic_Inputs
    },
    
    {
        path: '/admin/form-horizontal',
        name: 'admin/form-horizontal',
        component: AdminForm_Horizontal
    },

    {
        path: '/admin/form-input-groups',
        name: 'admin/form-input-groups',
        component: AdminForm_Input_Groups
    },

    {
        path: '/admin/form-mask',
        name: 'admin/form-mask',
        component: AdminForm_Mask
    },

    {
        path: '/admin/form-validation',
        name: 'admin/form-validation',
        component: AdminForm_Validation
    },

    {
        path: '/admin/form-vertical',
        name: 'admin/form-vertical',
        component: AdminForm_Vertical
    },

    {
        path: '/admin/blank-page',
        name: 'admin/blank-page',
        component: AdminBlank_Page
    },

    {
        path: '/admin/specialities',
        name: 'admin/specialities',
        component: AdminSpecialities
    },

    {
        path: '/admin/doctor-list',
        name: 'admin/doctor-list',
        component: AdminDoctor_List
    },

    {
        path: '/admin/patient-list',
        name: 'admin/patient-list',
        component: AdminPatient_List
    },

    {
        path: '/admin/reviews',
        name: 'admin/reviews',
        component: AdminReviews
    },

    {
        path: '/admin/transactions-list',
        name: 'admin/transactions-list',
        component: AdminTransactions_List
    },

    {
        path: '/admin/invoice-report',
        name: 'admin/invoice-report',
        component: AdminInvoice_Report
    },

    {
        path: '/admin/invoice',
        name: 'admin/invoice',
        component: AdminInvoice
    },

    {
        path: '/admin/tables-basic',
        name: 'admin/tables-basic',
        component:AdminTables_Basic
    },

    {
        path: '/admin/data-tables',
        name: 'admin/data-tables',
        component: AdminData_Tables
    },

    {
        path: '/admin/index',
        name: 'admin/index',
        component: AdminIndex
    },    
    {
        path: '/admin/calendar',
        name: 'admin/calendar',
        component: AdminCalendar
    },


     /**************** Admin  *************/

     {
        path: '/pharmacy/index',
        name: 'pharmacy/index',
        component: Pharmacyindex
    },
    {
        path: '/pharmacy/settings',
        name: 'pharmacy/settings',
        component: PharmacySetting
    },
    {
        path: '/pharmacy/profile',
        name: 'pharmacy/profile',
        component: PharmacyProfile
    },
    {
        path: '/pharmacy/add-product',
        name: 'pharmacy/add-product',
        component: PharmacyAddProduct
    },
    {
        path: '/pharmacy/add-purchase',
        name: 'pharmacy/add-purchase',
        component: PharmacyAddPurchase
    },
    {
        path: '/pharmacy/add-supplier',
        name: 'pharmacy/add-supplier',
        component: PharmacyAddSupplier
    },

    {
        path: '/pharmacy/products',
        name: 'pharmacy/products',
        component: PharmacyProducts
    },
    {
        path: '/pharmacy/expired',
        name: 'pharmacy/expired',
        component: PharmacyExpired
    },
    {
        path: '/pharmacy/categories',
        name: 'pharmacy/categories',
        component: PharmacyCategories
    },
    {
        path: '/pharmacy/invoice-report',
        name: 'pharmacy/invoice-report',
        component: PharmacyInvoiceReport,
    },
    {
        path: '/pharmacy/order',
        name: 'pharmacy/order',
        component: PharmacyOrder,
    },
    {
        path: '/pharmacy/outstock',
        name: 'pharmacy/outstock',
        component: PharmacyOutstock,
    },
    {
        path: '/pharmacy/purchase',
        name: 'pharmacy/purchase',
        component: PharmacyPurchase,
    },
    {
        path: '/pharmacy/sales',
        name: 'pharmacy/sales',
        component: PharmacySales,
    },
    {
        path: '/pharmacy/transactions-list',
        name: 'pharmacy/transactions-list',
        component: PharmacyTransaction,
    },
    {
        path: '/pharmacy/supplier',
        name: 'pharmacy/supplier',
        component: PharmacySupplier,
    },
    {
        path: '/pharmacy/edit-product',
        name: 'pharmacy/edit-product',
        component: PharmacyEditProduct,
    },
    {
        path: '/pharmacy/edit-purchase',
        name: 'pharmacy/edit-purchase',
        component: PharmacyEditPurchase,
    },
    {
        path: '/pharmacy/edit-supplier',
        name: 'pharmacy/edit-supplier',
        component: PharmacyEditSupplier,
    },
    {
        path: '/pharmacy/invoice',
        name: 'pharmacy/invoice',
        component: PharmacyInvoice,
    },
    {
        path: '/pharmacy/login',
        name: 'pharmacy/login',
        component: PharmacyLogin,
    },
    {
        path: '/pharmacy/forgot-password',
        name: 'pharmacy/forgot-password',
        component: Pharmacyforgotpassword,
    },
    {
        path: '/pharmacy/register',
        name: 'pharmacy/register',
        component: Pharmacyregister,
    }
]


export const router = createRouter({
    history: createWebHistory('/vuejs/template-rtl/'),
    linkActiveClass: 'active',
    routes,
}); 

router.beforeEach((to, from, next) => {
// Scroll to the top of the page
window.scrollTo({ top: 0, behavior: 'smooth' });

// Continue with the navigation
next();
});