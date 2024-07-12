<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />
    <div class="page-wrapper">
      <div class="content">
        <div class="container">
          <div class="row">
            <doctorsidebar></doctorsidebar>

            <div class="col-md-7 col-lg-8 col-xl-9">
              <div class="doc-review review-listing">
                <!-- Review Listing -->
                <ul class="comments-list">
                  <!-- Comment List -->
                  <li>
                    <div class="comment">
                      <img
                        class="avatar rounded-circle"
                        alt="User Image"
                        src="@/assets/img/patients/patient.jpg"
                      />
                      <div class="comment-body">
                        <div class="meta-data">
                          <span class="comment-author">Richard Wilson</span>
                          <span class="comment-date">Reviewed 2 Days ago</span>
                          <div class="review-count rating">
                            <i class="fas fa-star filled"></i>
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star me-1"></i>
                          </div>
                        </div>
                        <p class="recommended">
                          <i class="far fa-thumbs-up"></i> I recommend the doctor
                        </p>
                        <p class="comment-content">
                          Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                          eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                          enim ad minim veniam, quis nostrud exercitation. Curabitur non
                          nulla sit amet nisl tempus
                        </p>
                        <div class="comment-reply">
                          <a class="comment-btn" href="javascript:;">
                            <i class="fas fa-reply"></i> Reply
                          </a>
                          <p class="recommend-btn">
                            <span>Recommend?</span>
                            <a href="javascript:;" class="like-btn">
                              <i class="far fa-thumbs-up"></i> Yes
                            </a>
                            <a href="javascript:;" class="dislike-btn">
                              <i class="far fa-thumbs-down"></i> No
                            </a>
                          </p>
                        </div>
                      </div>
                    </div>

                    <!-- Comment Reply -->
                    <ul class="comments-reply">
                      <!-- Comment Reply List -->
                      <li>
                        <div class="comment">
                          <img
                            class="avatar rounded-circle"
                            alt="User Image"
                            src="@/assets/img/doctors/doctor-thumb-02.jpg"
                          />
                          <div class="comment-body">
                            <div class="meta-data">
                              <span class="comment-author">Dr. Darren Elder</span>
                              <span class="comment-date">Reviewed 3 Days ago</span>
                            </div>
                            <p class="comment-content">
                              Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                              sed do eiusmod tempor incididunt ut labore et dolore magna
                              aliqua. Ut enim ad minim veniam. Curabitur non nulla sit
                              amet nisl tempus
                            </p>
                            <div class="comment-reply">
                              <a class="comment-btn" href="javascript:;">
                                <i class="fas fa-reply"></i> Reply
                              </a>
                            </div>
                          </div>
                        </div>
                      </li>
                      <!-- /Comment Reply List -->
                    </ul>
                    <!-- /Comment Reply -->
                  </li>
                  <!-- /Comment List -->

                  <!-- Comment List -->
                  <li v-for="item in Reviews" :key="item.id">
                    <div class="comment">
                      <img
                        class="avatar rounded-circle"
                        alt="User Image"
                        :src="require(`@/assets/img/patients/${item.avatar}`)"
                      />
                      <div class="comment-body">
                        <div class="meta-data">
                          <span class="comment-author">{{ item.author }}</span>
                          <span class="comment-date">{{ item.date }}</span>
                          <div class="review-count rating">
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star filled me-1"></i>
                            <i class="fas fa-star filled me-1"></i>
                          </div>
                        </div>
                        <p class="comment-content">
                          {{ item.content }}
                        </p>
                        <div class="comment-reply">
                          <a class="comment-btn" href="javascript:;">
                            <i class="fas fa-reply"></i> Reply
                          </a>
                          <p class="recommend-btn">
                            <span>Recommend?</span>
                            <a href="javascript:;" class="like-btn">
                              <i class="far fa-thumbs-up"></i> Yes
                            </a>
                            <a href="javascript:;" class="dislike-btn">
                              <i class="far fa-thumbs-down"></i> No
                            </a>
                          </p>
                        </div>
                      </div>
                    </div>
                  </li>
                  <!-- /Comment List -->
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
      <indexfooter />
    </div>
  </div>
</template>
<script>
import Reviews from "@/assets/json/doctor/reviews.json";
export default {
  data() {
    return {
      title: "Reviews",
      text: "Home",
      text1: "Reviews",
      Reviews: Reviews,
    };
  },
};
</script>
