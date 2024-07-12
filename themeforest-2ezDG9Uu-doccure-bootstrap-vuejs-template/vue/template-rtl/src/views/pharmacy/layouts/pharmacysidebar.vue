<template>
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
            <li :class="currentPath == 'pharmacy/index' ? 'active' : 'notactive'">
              <router-link to="/pharmacy/index"
                ><i class="fe fe-home"></i> <span>Dashboard</span></router-link
              >
            </li>
            <li class="submenu">
              <a
                href="#sidebarproductsMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarproductsMenu"
                :class="{ active: productsMenu, subdrop: productsMenu }"
                @click.prevent="toggleproductsMenu"
                ><i class="fe fe-document"></i> <span> Products</span>
                <span class="menu-arrow"></span
              ></a>

              <ul
                class="collapse menu-dropdown"
                id="sidebarproductsMenu"
                :class="{ show: productsMenu }"
              >
                <li>
                  <router-link
                    :class="
                      currentPath == 'pharmacy/products' ||
                      currentPath == 'pharmacy/edit-product'
                        ? 'active'
                        : 'notactive'
                    "
                    to="/pharmacy/products"
                    >Products</router-link
                  >
                </li>
                <li>
                  <router-link
                    :class="
                      currentPath == 'pharmacy/add-product' ? 'active' : 'notactive'
                    "
                    to="/pharmacy/add-product"
                    >Add Product</router-link
                  >
                </li>
                <li>
                  <router-link
                    :class="currentPath == 'pharmacy/outstock' ? 'active' : 'notactive'"
                    to="/pharmacy/outstock"
                    >Out-Stock</router-link
                  >
                </li>
                <li>
                  <router-link
                    :class="currentPath == 'pharmacy/expired' ? 'active' : 'notactive'"
                    to="/pharmacy/expired"
                    >Expired</router-link
                  >
                </li>
              </ul>
            </li>
            <li :class="currentPath == 'pharmacy/categories' ? 'active' : 'notactive'">
              <router-link to="/pharmacy/categories"
                ><i class="fe fe-layout"></i> <span>Categories</span></router-link
              >
            </li>
            <li class="submenu">
              <a
                href="#sidebarpurchaseMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarpurchaseMenu"
                :class="{ active: purchaseMenu, subdrop: purchaseMenu }"
                @click.prevent="togglepurchaseMenu"
                ><i class="fe fe-star-o"></i> <span> Purchase</span>
                <span class="menu-arrow"></span
              ></a>

              <ul
                class="collapse menu-dropdown"
                id="sidebarpurchaseMenu"
                :class="{ show: purchaseMenu }"
              >
                <li>
                  <router-link
                    :class="
                      currentPath == 'pharmacy/purchase' ||
                      currentPath == 'pharmacy/edit-purchase'
                        ? 'active'
                        : 'notactive'
                    "
                    to="/pharmacy/purchase"
                    >Purchase</router-link
                  >
                </li>
                <li>
                  <router-link
                    :class="
                      currentPath == 'pharmacy/add-purchase' ? 'active' : 'notactive'
                    "
                    to="/pharmacy/add-purchase"
                    >Add Purchase</router-link
                  >
                </li>
                <li>
                  <router-link
                    :class="currentPath == 'pharmacy/order' ? 'active' : 'notactive'"
                    to="/pharmacy/order"
                    >Order</router-link
                  >
                </li>
              </ul>
            </li>
            <li :class="currentPath == 'pharmacy/sales' ? 'active' : 'notactive'">
              <router-link to="/pharmacy/sales"
                ><i class="fe fe-activity"></i> <span>Sales</span></router-link
              >
            </li>
            <li class="submenu">
              <a
                href="#sidebarsupplierMenu"
                data-bs-toggle="collapse"
                role="button"
                aria-expanded="false"
                aria-controls="sidebarsupplierMenu"
                :class="{ active: supplierMenu, subdrop: supplierMenu }"
                @click.prevent="togglesupplierMenu"
                ><i class="fe fe-user"></i> <span> Supplier</span>
                <span class="menu-arrow"></span
              ></a>
              <ul
                class="collapse menu-dropdown"
                id="sidebarsupplierMenu"
                :class="{ show: supplierMenu }"
              >
                <li>
                  <router-link
                    :class="
                      currentPath == 'pharmacy/supplier' ||
                      currentPath == 'pharmacy/edit-supplier'
                        ? 'active'
                        : 'notactive'
                    "
                    to="/pharmacy/supplier"
                    >Supplier</router-link
                  >
                </li>
                <li>
                  <router-link
                    :class="
                      currentPath == 'pharmacy/add-supplier' ? 'active' : 'notactive'
                    "
                    to="/pharmacy/add-supplier"
                    >Add Supplier</router-link
                  >
                </li>
              </ul>
            </li>
            <li
              :class="
                currentPath == 'pharmacy/transactions-list' ? 'active' : 'notactive'
              "
            >
              <router-link to="/pharmacy/transactions-list"
                ><i class="fe fe-table"></i> <span>Transaction</span></router-link
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
                    :class="
                      currentPath == 'pharmacy/invoice-report' ? 'active' : 'notactive'
                    "
                    to="/pharmacy/invoice-report"
                    >Invoice Reports</router-link
                  >
                </li>
              </ul>
            </li>
            <li class="menu-title">
              <span>Pages</span>
            </li>
            <li :class="currentPath == 'pharmacy/profile' ? 'active' : 'notactive'">
              <router-link to="/pharmacy/profile"
                ><i class="fe fe-user-plus"></i> <span>Profile</span></router-link
              >
            </li>
            <li :class="currentPath == 'pharmacy/settings' ? 'active' : 'notactive'">
              <router-link to="/pharmacy/settings"
                ><i class="fe fe-vector"></i> <span>Settings</span></router-link
              >
            </li>
          </ul>
        </div>
      </perfect-scrollbar>
    </div>
  </div>
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
      productsMenuData: false,
      purchaseMenuData: false,
      supplierMenuData: false,
      reportsMenuData: false,
      activeClass: "active",
    };
  },
  methods: {
    scrollHanle(evt) {},
    toggleproductsMenu() {
      this.productsMenuData = !this.productsMenuData;
    },
    togglepurchaseMenu() {
      this.purchaseMenuData = !this.purchaseMenuData;
    },
    togglesupplierMenu() {
      this.supplierMenuData = !this.supplierMenuData;
    },
    togglereportsMenu() {
      this.reportsMenuData = !this.reportsMenuData;
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
    productsMenu() {
      return (
        this.$route.name == "pharmacy/products" ||
        this.$route.name == "pharmacy/add-product" ||
        this.$route.name == "pharmacy/outstock" ||
        this.$route.name == "pharmacy/expired" ||
        this.$route.name == "pharmacy/edit-product"
      );
    },
    purchaseMenu() {
      return (
        this.$route.name == "pharmacy/purchase" ||
        this.$route.name == "pharmacy/add-purchase" ||
        this.$route.name == "pharmacy/edit-purchase" ||
        this.$route.name == "pharmacy/order"
      );
    },

    supplierMenu() {
      return (
        this.$route.name == "pharmacy/supplier" ||
        this.$route.name == "pharmacy/add-supplier" ||
        this.$route.name == "pharmacy/edit-supplier"
      );
    },
    reportsMenu() {
      return this.$route.name == "pharmacy/invoice-report";
    },
  },
};
</script>
