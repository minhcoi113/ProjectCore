<template>
  <!-- Blog Sidebar -->
  <div class="col-lg-4 col-md-12 sidebar-right theiaStickySidebar">
    <div class="stickysidebar">
      <!-- Search -->
      <div class="card search-widget">
        <div class="card-body">
          <form class="search-form">
            <div class="input-group">
              <input type="text" placeholder="Search..." class="form-control" />
              <b-button type="submit" variant="primary"
                ><i class="fa fa-search"></i
              ></b-button>
            </div>
          </form>
        </div>
      </div>
      <!-- /Search -->

      <!-- Latest Posts -->
      <div class="card post-widget">
        <div class="card-header">
          <h4 class="card-title">Latest Posts</h4>
        </div>
        <div class="card-body">
          <ul class="latest-posts">
            <li v-for="item in BlogSidebar" :key="item.id">
              <div class="post-thumb">
                <router-link to="/blog-details">
                  <img
                    class="img-fluid"
                    :src="require(`@/assets/img/blog/${item.Image}`)"
                    alt="blog-image"
                  />
                </router-link>
              </div>
              <div class="post-info">
                <h4>
                  <router-link to="/blog-details">{{ item.Title }}</router-link>
                </h4>
                <p>{{ item.Day }}</p>
              </div>
            </li>
          </ul>
        </div>
      </div>
      <!-- /Latest Posts -->

      <!-- Categories -->
      <div class="card category-widget">
        <div class="card-header">
          <h4 class="card-title">Blog Categories</h4>
        </div>
        <div class="card-body">
          <ul class="categories">
            <li>
              <a href="javascript:;">Cardiology <span>(62)</span></a>
            </li>
            <li>
              <a href="javascript:;">Health Care <span>(27)</span></a>
            </li>
            <li>
              <a href="javascript:;">Nutritions <span>(41)</span></a>
            </li>
            <li>
              <a href="javascript:;">Health Tips <span>(16)</span></a>
            </li>
            <li>
              <a href="javascript:;">Medical Research <span>(55)</span></a>
            </li>
            <li>
              <a href="javascript:;">Health Treatment <span>(07)</span></a>
            </li>
          </ul>
        </div>
      </div>
      <!-- /Categories -->

      <!-- Tags -->
      <div class="card tags-widget">
        <div class="card-header">
          <h4 class="card-title">Tags</h4>
        </div>
        <div class="card-body">
          <ul class="tags">
            <li><a href="javascript:;" class="tag">Children</a></li>
            <li><a href="javascript:;" class="tag">Disease</a></li>
            <li><a href="javascript:;" class="tag">Appointment</a></li>
            <li><a href="javascript:;" class="tag">Booking</a></li>
            <li><a href="javascript:;" class="tag">Kids</a></li>
            <li><a href="javascript:;" class="tag">Health</a></li>
            <li><a href="javascript:;" class="tag">Family</a></li>
            <li><a href="javascript:;" class="tag">Tips</a></li>
            <li><a href="javascript:;" class="tag">Shedule</a></li>
            <li><a href="javascript:;" class="tag">Treatment</a></li>
            <li><a href="javascript:;" class="tag">Dr</a></li>
            <li><a href="javascript:;" class="tag">Clinic</a></li>
            <li><a href="javascript:;" class="tag">Online</a></li>
            <li><a href="javascript:;" class="tag">Health Care</a></li>
            <li><a href="javascript:;" class="tag">Consulting</a></li>
            <li><a href="javascript:;" class="tag">Doctors</a></li>
            <li><a href="javascript:;" class="tag">Neurology</a></li>
            <li><a href="javascript:;" class="tag">Dentists</a></li>
            <li><a href="javascript:;" class="tag">Specialist</a></li>
            <li><a href="javascript:;" class="tag">Doccure</a></li>
          </ul>
        </div>
      </div>
      <!-- /Tags -->
    </div>
  </div>
  <!-- /Blog Sidebar -->
</template>

<script>
import BlogSidebar from "@/assets/json/blogsidebar.json";
export default {
  data() {
    return {
      BlogSidebar: BlogSidebar,
    };
  },
};
</script>
