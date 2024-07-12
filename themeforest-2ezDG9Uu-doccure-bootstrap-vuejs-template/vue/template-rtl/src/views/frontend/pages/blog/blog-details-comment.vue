<template>
  <div class="card blog-comments clearfix">
    <div class="card-header">
      <h4 class="card-title">Comments (12)</h4>
    </div>
    <div class="card-body pb-0">
      <ul class="comments-list">
        <li>
          <div class="comment">
            <div class="comment-author">
              <img
                class="avatar"
                alt="Michelle Fairfax"
                src="@/assets/img/patients/patient4.jpg"
              />
            </div>
            <div class="comment-block">
              <span class="comment-by">
                <span class="blog-author-name">Michelle Fairfax</span>
              </span>
              <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra
                euismod odio, gravida pellentesque urna varius vitae, gravida pellentesque
                urna varius vitae. Lorem ipsum dolor sit amet, consectetur adipiscing
                elit.
              </p>
              <p class="blog-date">Dec 6, 2023</p>
              <a class="comment-btn" href="javascript:;">
                <i class="fas fa-reply"></i> Reply
              </a>
            </div>
          </div>
          <ul class="comments-list reply">
            <li>
              <div class="comment">
                <div class="comment-author">
                  <img
                    class="avatar"
                    alt="Gina Moore"
                    src="@/assets/img/patients/patient5.jpg"
                  />
                </div>
                <div class="comment-block">
                  <span class="comment-by">
                    <span class="blog-author-name">Gina Moore</span>
                  </span>
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra
                    euismod odio, gravida pellentesque urna varius vitae, gravida
                    pellentesque urna varius vitae.
                  </p>
                  <p class="blog-date">Dec 6, 2023</p>
                  <a class="comment-btn" href="javascript:;">
                    <i class="fas fa-reply"></i> Reply
                  </a>
                </div>
              </div>
            </li>
            <li>
              <div class="comment">
                <div class="comment-author">
                  <img
                    class="avatar"
                    alt="Carl Kelly"
                    src="@/assets/img/patients/patient3.jpg"
                  />
                </div>
                <div class="comment-block">
                  <span class="comment-by">
                    <span class="blog-author-name">Carl Kelly</span>
                  </span>
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam viverra
                    euismod odio, gravida pellentesque urna varius vitae, gravida
                    pellentesque urna varius vitae.
                  </p>
                  <p class="blog-date">December 7, 2023</p>
                  <a class="comment-btn" href="javascript:;">
                    <i class="fas fa-reply"></i> Reply
                  </a>
                </div>
              </div>
            </li>
          </ul>
        </li>
        <li>
          <div class="comment">
            <div class="comment-author">
              <img
                class="avatar"
                alt="Elsie Gilley"
                src="@/assets/img/patients/patient6.jpg"
              />
            </div>
            <div class="comment-block">
              <span class="comment-by">
                <span class="blog-author-name">Elsie Gilley</span>
              </span>
              <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
              <p class="blog-date">December 11, 2023</p>
            </div>
          </div>
        </li>
        <li>
          <div class="comment">
            <div class="comment-author">
              <img
                class="avatar"
                alt="Joan Gardner"
                src="@/assets/img/patients/patient7.jpg"
              />
            </div>
            <div class="comment-block">
              <span class="comment-by">
                <span class="blog-author-name">Joan Gardner</span>
              </span>
              <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
              <p class="blog-date">December 13, 2023</p>
              <a class="comment-btn" href="javascript:;">
                <i class="fas fa-reply"></i> Reply
              </a>
            </div>
          </div>
        </li>
      </ul>
    </div>
  </div>
  <div class="card new-comment clearfix">
    <div class="card-header">
      <h4 class="card-title">Leave Comment</h4>
    </div>
    <div class="card-body">
      <form>
        <div class="mb-3">
          <label class="mb-2">Name <span class="text-danger">*</span></label>
          <input type="text" class="form-control" />
        </div>
        <div class="mb-3">
          <label class="mb-2"
            >Your Email Address <span class="text-danger">*</span></label
          >
          <input type="email" class="form-control" />
        </div>
        <div class="mb-3">
          <label class="mb-2">Comments</label>
          <textarea rows="4" class="form-control"></textarea>
        </div>
        <div class="submit-section">
          <b-button class="btn btn-primary submit-btn" type="submit">Submit</b-button>
        </div>
      </form>
    </div>
  </div>
</template>
