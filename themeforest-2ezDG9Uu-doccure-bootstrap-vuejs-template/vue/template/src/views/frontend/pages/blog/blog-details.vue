<template>
  <div class="main-wrapper">
    <layoutheader></layoutheader>
    <breadcrumb :title="title" :text="text" :text1="text1" />

    <div class="page-wrapper">
      <!-- Page Content -->
      <div class="content">
        <div class="container">
          <div class="row">
            <div class="col-lg-8 col-md-12">
              <div class="blog-view">
                <div class="blog blog-single-post">
                  <div class="blog-image">
                    <a href="javascript:void(0);"
                      ><img
                        alt="blog-image"
                        src="@/assets/img/blog/blog-01.jpg"
                        class="img-fluid"
                    /></a>
                  </div>
                  <h3 class="blog-title">Doccure – Making your clinic painless visit?</h3>
                  <div class="blog-info clearfix">
                    <div class="post-left">
                      <ul>
                        <li>
                          <div class="post-author">
                            <router-link to="/doctor-profile"
                              ><img
                                src="@/assets/img/doctors/doctor-thumb-02.jpg"
                                alt="Post Author"
                              />
                              <span>Dr. Darren Elder</span></router-link
                            >
                          </div>
                        </li>
                        <li><i class="far fa-calendar"></i>4 Jan 2023</li>
                        <li><i class="far fa-comments"></i>12 Comments</li>
                        <li><i class="fa fa-tags"></i>Health Tips</li>
                      </ul>
                    </div>
                  </div>
                  <div class="blog-content">
                    <p>
                      Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                      eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim
                      ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut
                      aliquip ex ea commodo consequat. Duis aute irure dolor in
                      reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla
                      pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                      culpa qui officia deserunt mollit anim id est laborum.
                    </p>
                    <p>
                      Sed ut perspiciatis unde omnis iste natus error sit voluptatem
                      accusantium doloremque laudantium, totam rem aperiam, eaque ipsa
                      quae ab illo inventore veritatis et quasi architecto beatae vitae
                      dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit
                      aspernatur aut odit aut fugit, sed quia consequuntur magni dolores
                      eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est,
                      qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit,
                      sed quia non numquam eius modi tempora incidunt ut labore et dolore
                      magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis
                      nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut
                      aliquid ex ea commodi consequatur? Quis autem vel eum iure
                      reprehenderit qui in ea voluptate velit esse quam nihil molestiae
                      consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla
                      pariatur?
                    </p>
                    <p>
                      At vero eos et accusamus et iusto odio dignissimos ducimus qui
                      blanditiis praesentium voluptatum deleniti atque corrupti quos
                      dolores et quas molestias excepturi sint occaecati cupiditate non
                      provident, similique sunt in culpa qui officia deserunt mollitia
                      animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis
                      est et expedita distinctio. Nam libero tempore, cum soluta nobis est
                      eligendi optio cumque nihil impedit quo minus id quod maxime placeat
                      facere possimus, omnis voluptas assumenda est, omnis dolor
                      repellendus. Temporibus autem quibusdam et aut officiis debitis aut
                      rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint
                      et molestiae non recusandae. Itaque earum rerum hic tenetur a
                      sapiente delectus, ut aut reiciendis voluptatibus maiores alias
                      consequatur aut perferendis doloribus asperiores repellat.
                    </p>
                  </div>
                </div>

                <div class="card blog-share clearfix">
                  <div class="card-header">
                    <h4 class="card-title">Share the post</h4>
                  </div>
                  <div class="card-body">
                    <ul class="social-share">
                      <li>
                        <a href="javascript:;" title="Facebook"
                          ><i class="fab fa-facebook"></i
                        ></a>
                      </li>
                      <li>
                        <a href="javascript:;" title="Twitter"
                          ><i class="fab fa-twitter"></i
                        ></a>
                      </li>
                      <li>
                        <a href="javascript:;" title="Linkedin"
                          ><i class="fab fa-linkedin"></i
                        ></a>
                      </li>
                      <li>
                        <a href="javascript:;" title="Google Plus"
                          ><i class="fab fa-google-plus"></i
                        ></a>
                      </li>
                      <li>
                        <a href="javascript:;" title="Youtube"
                          ><i class="fab fa-youtube"></i
                        ></a>
                      </li>
                    </ul>
                  </div>
                </div>
                <div class="card author-widget clearfix">
                  <div class="card-header">
                    <h4 class="card-title">About Author</h4>
                  </div>
                  <div class="card-body">
                    <div class="about-author">
                      <div class="about-author-img">
                        <div class="author-img-wrap">
                          <router-link to="/doctor-profile"
                            ><img
                              class="img-fluid rounded-circle"
                              alt="Darren Elder"
                              src="@/assets/img/doctors/doctor-thumb-02.jpg"
                          /></router-link>
                        </div>
                      </div>
                      <div class="author-details">
                        <router-link to="/doctor-profile" class="blog-author-name"
                          >Dr. Darren Elder</router-link
                        >
                        <p class="mb-0">
                          Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
                          eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
                          enim ad minim veniam, quis nostrud exercitation.
                        </p>
                      </div>
                    </div>
                  </div>
                </div>

                <blogdetailscomment></blogdetailscomment>
              </div>
            </div>

            <!-- Blog Sidebar -->
            <blogsidebar></blogsidebar>
            <!-- /Blog Sidebar -->
          </div>
        </div>
      </div>
      <!-- /Page Content -->
    </div>
  </div>
  <indexfooter></indexfooter>
</template>

<script>
export default {
  data() {
    return {
      title: "Blog Details",
      text: "Home",
      text1: "Blog Details",
    };
  },
};
</script>
