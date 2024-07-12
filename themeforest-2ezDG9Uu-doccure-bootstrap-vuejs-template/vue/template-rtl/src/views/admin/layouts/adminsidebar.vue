<template>
  <!-- Sidebar -->
  <div class="sidebar" id="sidebar">
    <div class="sidebar-inner slimscroll">
      <perfect-scrollbar
        class="scroll-area"
        :settings="settings"
        @ps-scroll-y="scrollHanle"
      >
        <div id="sidebar-menu" class="sidebar-menu">
          <ul>
            <li class="menu-title">
              <span>Main</span>
            </li>
            <li :class="currentPath == 'admin/index' ? 'active' : 'notactive'">
              <router-link to="/admin/index"
                ><i class="fe fe-home"></i> <span>Dashboard</span></router-link
              >
            </li>
            <li :class="currentPath == 'admin/appointment-list' ? 'active' : 'notactive'">
              <router-link to="/admin/appointment-list"
                ><i class="fe fe-layout"></i> <span>Appointments</span></router-link
              >
            </li>
            <li :class="currentPath == 'admin/specialities' ? 'active' : 'notactive'">
              <router-link to="/admin/specialities"
                ><i class="fe fe-users"></i> <span>Specialities</span></router-link
              >
            </li>
            <li :class="currentPath == 'admin/doctor-list' ? 'active' : 'notactive'">
              <router-link to="/admin/doctor-list"
                ><i class="fe fe-user-plus"></i> <span>Doctors</span></router-link
              >
            </li>
            <li :class="currentPath == 'admin/patient-list' ? 'active' : 'notactive'">
              <router-link to="/admin/patient-list"
                ><i class="fe fe-user"></i> <span>Patients</span></router-link
              >
            </li>
            <li :class="currentPath == 'admin/reviews' ? 'active' : 'notactive'">
              <router-link to="/admin/reviews"
                ><i class="fe fe-star-o"></i> <span>Reviews</span></router-link
              >
            </li>
            <li
              :class="currentPath == 'admin/transactions-list' ? 'active' : 'notactive'"
            >
              <router-link to="/admin/transactions-list"
                ><i class="fe fe-activity"></i> <span>Transactions</span></router-link
              >
            </li>
            <li :class="currentPath == 'admin/settings' ? 'active' : 'notactive'">
              <router-link to="/admin/settings"
                ><i class="fe fe-vector"></i> <span>Settings</span></router-link
              >
            </li>
            <li class="submenu">
              <a
                href="#sidebarreportsMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarreportsMenu"
                :class="{ active: reportsMenu, subdrop: reportsMenu }"
                @click.prevent="togglereportsMenu"
                ><i class="fe fe-document"></i> <span> Reports</span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebarreportsMenu"
                :class="{ show: reportsMenu }"
              >
                <li>
                  <router-link
                    to="/admin/invoice-report"
                    :class="
                      currentPath == 'admin/invoice-report' ||
                      currentPath == 'admin/invoice'
                        ? 'active'
                        : 'notactive'
                    "
                    >Invoice Reports</router-link
                  >
                </li>
              </ul>
            </li>
            <li class="menu-title">
              <span>Pages</span>
            </li>
            <li :class="currentPath == 'admin/profile' ? 'active' : 'notactive'">
              <router-link to="/admin/profile"
                ><i class="fe fe-user-plus"></i> <span>Profile</span></router-link
              >
            </li>
            <li class="submenu">
              <a
                href="#sidebarauthenticationMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarauthenticationMenu"
                :class="{ active: authenticationMenu, subdrop: authenticationMenu }"
                @click.prevent="toggleauthenticationMenu"
                ><i class="fe fe-document"></i> <span> Authentication</span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebarauthenticationMenu"
                :class="{ show: authenticationMenu }"
              >
                <li><router-link to="/admin/login"> Login </router-link></li>
                <li><router-link to="/admin/register"> Register </router-link></li>
                <li>
                  <router-link to="/admin/forgot-password"> Forgot Password </router-link>
                </li>
                <li><router-link to="/admin/lock-screen"> Lock Screen </router-link></li>
              </ul>
            </li>
            <li class="submenu">
              <a
                href="#sidebarerrorMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarerrorMenu"
                :class="{ active: errorMenu, subdrop: errorMenu }"
                @click.prevent="toggleerrorMenu"
                ><i class="fe fe-warning"></i> <span> Error Pages </span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebarerrorMenu"
                :class="{ show: errorMenu }"
              >
                <li><router-link to="/admin/error-404">404 Error </router-link></li>
                <li><router-link to="/admin/error-500">500 Error </router-link></li>
              </ul>
            </li>
            <li :class="currentPath == 'admin/blank-page' ? 'active' : 'notactive'">
              <router-link to="/admin/blank-page"
                ><i class="fe fe-file"></i> <span>Blank Page</span></router-link
              >
            </li>
            <li class="menu-title">
              <span>UI Interface</span>
            </li>
            <li :class="currentPath == 'admin/components' ? 'active' : 'notactive'">
              <router-link to="/admin/components"
                ><i class="fe fe-vector"></i> <span>Components</span></router-link
              >
            </li>
            <li class="submenu">
              <a
                href="#sidebarformsMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarformsMenu"
                :class="{ active: formsMenu, subdrop: formsMenu }"
                @click.prevent="toggleformsMenu"
                ><i class="fe fe-document"></i> <span> Forms </span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebarformsMenu"
                :class="{ show: formsMenu }"
              >
                <li>
                  <router-link
                    to="/admin/form-basic-inputs"
                    :class="
                      currentPath == 'admin/form-basic-inputs' ? 'active' : 'notactive'
                    "
                    >Basic Inputs
                  </router-link>
                </li>
                <li>
                  <router-link
                    to="/admin/form-input-groups"
                    :class="
                      currentPath == 'admin/form-input-groups' ? 'active' : 'notactive'
                    "
                    >Input Groups
                  </router-link>
                </li>
                <li>
                  <router-link
                    to="/admin/form-horizontal"
                    :class="
                      currentPath == 'admin/form-horizontal' ? 'active' : 'notactive'
                    "
                    >Horizontal Form
                  </router-link>
                </li>
                <li>
                  <router-link
                    to="/admin/form-vertical"
                    :class="currentPath == 'admin/form-vertical' ? 'active' : 'notactive'"
                  >
                    Vertical Form
                  </router-link>
                </li>
                <li>
                  <router-link
                    to="/admin/form-mask"
                    :class="currentPath == 'admin/form-mask' ? 'active' : 'notactive'"
                  >
                    Form Mask
                  </router-link>
                </li>
                <li>
                  <router-link
                    to="/admin/form-validation"
                    :class="
                      currentPath == 'admin/form-validation' ? 'active' : 'notactive'
                    "
                  >
                    Form Validation
                  </router-link>
                </li>
              </ul>
            </li>
            <li class="submenu">
              <a
                href="#sidebartablesMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebartablesMenu"
                :class="{ active: tablesMenu, subdrop: tablesMenu }"
                @click.prevent="toggletablesMenu"
                ><i class="fe fe-document"></i> <span> Tables </span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebartablesMenu"
                :class="{ show: tablesMenu }"
              >
                <li>
                  <router-link
                    to="/admin/tables-basic"
                    :class="currentPath == 'admin/tables-basic' ? 'active' : 'notactive'"
                    >Basic Tables
                  </router-link>
                </li>
                <li>
                  <router-link
                    to="/admin/data-tables"
                    :class="currentPath == 'admin/data-tables' ? 'active' : 'notactive'"
                    >Data Table
                  </router-link>
                </li>
              </ul>
            </li>
            <li class="submenu">
              <a
                href="#sidebarmultilevelMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarmultilevelMenu"
                :class="{ active: multilevelMenu, subdrop: multilevelMenu }"
                @click.prevent="togglemultilevelMenu"
                ><i class="fe fe-document"></i> <span> Multi Level </span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebarmultilevelMenu"
                :class="{ show: multilevelMenu }"
              >
                <li class="submenu">
                  <a href="javascript:void(0);">
                    <span>Level 1</span> <span class="menu-arrow"></span
                  ></a>
                  <ul
                    class="collapse menu-dropdown"
                    id="sidebarmultilevelMenu"
                    :class="{ show: multilevelMenu }"
                  >
                    <li>
                      <a href="javascript:void(0);"><span>Level 2</span></a>
                    </li>
                    <li class="submenu">
                      <a href="javascript:void(0);">
                        <span> Level 2</span> <span class="menu-arrow"></span
                      ></a>
                      <ul style="display: none">
                        <li>
                          <a href="javascript:void(0);">Level 3</a>
                        </li>
                        <li>
                          <a href="javascript:void(0);">Level 3</a>
                        </li>
                      </ul>
                    </li>
                    <li>
                      <a href="javascript:void(0);"> <span>Level 2</span></a>
                    </li>
                  </ul>
                </li>
                <li>
                  <a href="javascript:void(0);"> <span>Level 1</span></a>
                </li>
              </ul>
            </li>
          </ul>
        </div>
      </perfect-scrollbar>
    </div>
  </div>
  <!-- /Sidebar -->
</template>

<script>
import { PerfectScrollbar } from "vue3-perfect-scrollbar";
import "vue3-perfect-scrollbar/dist/vue3-perfect-scrollbar.css";
export default {
  data() {
    return {
      settings: {
        suppressScrollX: true,
      },
      reportsMenuData: false,
      authenticationMenuData: false,
      errorMenuData: false,
      formMenuData: false,
      tablesMenuData: false,
      multilevelMenuData: false,
      activeClass: "active",
    };
  },
  methods: {
    scrollHanle(evt) {},
    togglereportsMenu() {
      this.reportsMenuData = !this.reportsMenuData;
    },
    toggleauthenticationMenu() {
      this.authenticationMenuData = !this.authenticationMenuData;
    },
    toggleerrorMenu() {
      this.errorMenuData = !this.errorMenuData;
    },
    toggleformsMenu() {
      this.formsMenuData = !this.formsMenuData;
    },
    toggletablesMenu() {
      this.tablesMenuData = !this.tablesMenuData;
    },
    togglemultilevelMenu() {
      this.multilevelMenuData = !this.multilevelMenuData;
    },
    isCustomDropdown() {
      //Search bar
      var searchOptions = document.getElementById("search-close-options");
      var dropdown = document.getElementById("search-dropdown");
      var searchInput = document.getElementById("search-options");

      searchInput.addEventListener("focus", () => {
        var inputLength = searchInput.value.length;
        if (inputLength > 0) {
          dropdown.classList.add("show");
          searchOptions.classList.remove("d-none");
        } else {
          dropdown.classList.remove("show");
          searchOptions.classList.add("d-none");
        }
      });

      searchInput.addEventListener("keyup", () => {
        var inputLength = searchInput.value.length;
        if (inputLength > 0) {
          dropdown.classList.add("show");
          searchOptions.classList.remove("d-none");
        } else {
          dropdown.classList.remove("show");
          searchOptions.classList.add("d-none");
        }
      });

      searchOptions.addEventListener("click", () => {
        searchInput.value = "";
        dropdown.classList.remove("show");
        searchOptions.classList.add("d-none");
      });

      document.body.addEventListener("click", (e) => {
        if (e.target.getAttribute("id") !== "search-options") {
          dropdown.classList.remove("show");
          searchOptions.classList.add("d-none");
        }
      });
    },
    initActiveMenu(ele) {
      setTimeout(() => {
        if (document.querySelector("#sidebar")) {
          let a = document
            .querySelector("#sidebar")
            .querySelector('[href="' + ele + '"]');

          if (a) {
            a.classList.add("active");
            let parentCollapseDiv = a.closest(".collapse.menu-dropdown");
            if (parentCollapseDiv) {
              parentCollapseDiv.classList.add("show");
              parentCollapseDiv.parentElement.children[0].classList.add("active");
              parentCollapseDiv.parentElement.children[0].setAttribute(
                "aria-expanded",
                "true"
              );
              if (parentCollapseDiv.parentElement.closest(".collapse.menu-dropdown")) {
                parentCollapseDiv.parentElement
                  .closest(".collapse")
                  .classList.add("show");
                if (
                  parentCollapseDiv.parentElement.closest(".collapse")
                    .previousElementSibling
                )
                  parentCollapseDiv.parentElement
                    .closest(".collapse")
                    .previousElementSibling.classList.add("active");
              }
            }
          }
        }
      }, 1000);
    },
  },
  components: {
    PerfectScrollbar,
  },
  computed: {
    currentPath() {
      return this.$route.name;
    },
    reportsMenu() {
      return (
        this.$route.name == "admin/invoice-report" || this.$route.name == "admin/invoice"
      );
    },
    authenticationMenu() {
      return (
        this.$route.name == "admin/forgot-password" ||
        this.$route.name == "admin/lock-screen" ||
        this.$route.name == "admin/login" ||
        this.$route.name == "admin/register"
      );
    },

    errorMenu() {
      return (
        this.$route.name == "admin/error-404" || this.$route.name == "admin/error-500"
      );
    },
    tablesMenu() {
      return (
        this.$route.name == "admin/data-tables" ||
        this.$route.name == "admin/tables-basic"
      );
    },

    formsMenu() {
      return (
        this.$route.name == "admin/form-basic-inputs" ||
        this.$route.name == "admin/form-input-groups" ||
        this.$route.name == "admin/form-horizontal" ||
        this.$route.name == "admin/form-mask" ||
        this.$route.name == "admin/form-validation" ||
        this.$route.name == "admin/form-vertical"
      );
    },

    multilevelMenu() {},
  },
};
</script>
