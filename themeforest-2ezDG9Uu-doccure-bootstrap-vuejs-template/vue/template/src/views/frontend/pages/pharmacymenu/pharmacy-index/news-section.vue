<template>
  <section class="section news-section">
    <div class="container">
      <div class="pharmacy-section-header">
        <div class="row align-items-center">
          <div class="col-md-6">
            <div class="pharmacy-title">
              <h4>Latest News</h4>
            </div>
          </div>
          <div class="col-md-6">
            <div class="pharmacy-title-link">
              <router-link to="blog-details"
                >View All <i class="fa-solid fa-arrow-right"></i
              ></router-link>
            </div>
          </div>
        </div>
      </div>
      <div class="row justify-content-center">
        <div class="col-lg-4 col-md-6 d-flex">
          <div class="news-grid flex-fill">
            <div class="news-image">
              <router-link to="blog-details">
                <img
                  src="@/assets/img/blog/blog-21.jpg"
                  class="img-fluid"
                  alt="Post Image"
                />
              </router-link>
              <div class="news-date">
                <h5>18</h5>
                <p>Nov</p>
              </div>
            </div>
            <div class="news-content">
              <ul class="nav">
                <li>
                  <p>
                    <img src="@/assets/img/icons/tag-icon.svg" alt="Icon" />
                    Food
                  </p>
                </li>
                <li>
                  <p>
                    <img
                      class="img-fluid"
                      src="@/assets/img/icons/admin-icon.svg"
                      alt="Icon"
                    />
                    By Admin
                  </p>
                </li>
                <li>
                  <p>
                    <img
                      class="img-fluid"
                      src="@/assets/img/icons/comment-icon.svg"
                      alt="Icon"
                    />
                    65 Comments
                  </p>
                </li>
              </ul>
              <h3 class="news-title">
                <router-link to="blog-details">
                  Revolutionizing Patient Care: The Future of Online Pharmacies
                </router-link>
              </h3>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-6 d-flex">
          <div class="news-grid flex-fill">
            <div class="news-image">
              <router-link to="blog-details">
                <img
                  src="@/assets/img/blog/blog-22.jpg"
                  class="img-fluid"
                  alt="Post Image"
                />
              </router-link>
              <div class="news-date">
                <h5>19</h5>
                <p>Nov</p>
              </div>
            </div>
            <div class="news-content">
              <ul class="nav">
                <li>
                  <p>
                    <img src="@/assets/img/icons/tag-icon.svg" alt="Icon" />
                    Food
                  </p>
                </li>
                <li>
                  <p>
                    <img
                      class="img-fluid"
                      src="@/assets/img/icons/admin-icon.svg"
                      alt="Icon"
                    />
                    By Admin
                  </p>
                </li>
                <li>
                  <p>
                    <img
                      class="img-fluid"
                      src="@/assets/img/icons/comment-icon.svg"
                      alt="Icon"
                    />
                    48 Comments
                  </p>
                </li>
              </ul>
              <h3 class="news-title">
                <router-link to="blog-details">
                  Navigating the World of Supplements: A Pharmacist's Perspective
                </router-link>
              </h3>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-md-6 d-flex">
          <div class="news-grid flex-fill">
            <div class="news-image">
              <router-link to="blog-details">
                <img
                  src="@/assets/img/blog/blog-23.jpg"
                  class="img-fluid"
                  alt="Post Image"
                />
              </router-link>
              <div class="news-date">
                <h5>20</h5>
                <p>Nov</p>
              </div>
            </div>
            <div class="news-content">
              <ul class="nav">
                <li>
                  <p>
                    <img src="@/assets/img/icons/tag-icon.svg" alt="Icon" />
                    Food
                  </p>
                </li>
                <li>
                  <p>
                    <img
                      class="img-fluid"
                      src="@/assets/img/icons/admin-icon.svg"
                      alt="Icon"
                    />
                    By Admin
                  </p>
                </li>
                <li>
                  <p>
                    <img
                      class="img-fluid"
                      src="@/assets/img/icons/comment-icon.svg"
                      alt="Icon"
                    />
                    26 Comments
                  </p>
                </li>
              </ul>
              <h3 class="news-title">
                <router-link to="blog-details">
                  Behind the Counter: A Glimpse into the Day-to-Day Life of a Pharmacist
                </router-link>
              </h3>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
