<template>
  <div role="tabpanel" id="doc_reviews" class="tab-pane fade">
    <!-- Review Listing -->
    <div class="widget review-listing">
      <ul class="comments-list">
        <!-- Comment List -->
        <li>
          <div class="comment">
            <img
              class="avatar avatar-sm rounded-circle"
              alt="User Image"
              src="@/assets/img/patients/patient.jpg"
            />
            <div class="comment-body">
              <div class="meta-data">
                <span class="comment-author">Armando Pack</span>
                <span class="comment-date">Reviewed 2 Days ago</span>
                <div class="review-count rating">
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star"></i>
                </div>
              </div>
              <p class="recommended">
                <i class="far fa-thumbs-up"></i> I recommend the doctor
              </p>
              <p class="comment-content">
                Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
                veniam, quis nostrud exercitation. Curabitur non nulla sit amet nisl
                tempus
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
            <li>
              <div class="comment">
                <img
                  class="avatar avatar-sm rounded-circle"
                  alt="User Image"
                  src="@/assets/img/patients/patient1.jpg"
                />
                <div class="comment-body">
                  <div class="meta-data">
                    <span class="comment-author">Lindsey Kesterson</span>
                    <span class="comment-date">Reviewed 3 Days ago</span>
                    <div class="review-count rating">
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star filled me-1"></i>
                      <i class="fas fa-star"></i>
                    </div>
                  </div>
                  <p class="comment-content">
                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do
                    eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad
                    minim veniam. Curabitur non nulla sit amet nisl tempus
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
          </ul>
          <!-- /Comment Reply -->
        </li>
        <!-- /Comment List -->

        <!-- Comment List -->
        <li>
          <div class="comment">
            <img
              class="avatar avatar-sm rounded-circle"
              alt="User Image"
              src="@/assets/img/patients/patient2.jpg"
            />
            <div class="comment-body">
              <div class="meta-data">
                <span class="comment-author">Travis Trimble</span>
                <span class="comment-date">Reviewed 4 Days ago</span>
                <div class="review-count rating me-1">
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star filled me-1"></i>
                  <i class="fas fa-star"></i>
                </div>
              </div>
              <p class="comment-content">
                Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
                tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
                veniam, quis nostrud exercitation. Curabitur non nulla sit amet nisl
                tempus
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

      <!-- Show All -->
      <div class="all-feedback text-center">
        <a href="javascript:;" class="btn btn-primary btn-sm">
          Show all feedback <strong>(167)</strong>
        </a>
      </div>
      <!-- /Show All -->
    </div>
    <!-- /Review Listing -->

    <!-- Write Review -->
    <div class="write-review">
      <h4>Write a review for <strong>Medlife Medical</strong></h4>

      <!-- Write Review Form -->
      <form>
        <div class="mb-3">
          <label class="mb-2">Review</label>
          <div class="star-rating">
            <input id="star-5" type="radio" name="rating" value="star-5" />
            <label class="me-1" for="star-5" title="5 stars">
              <i class="active fa fa-star"></i>
            </label>
            <input id="star-4" type="radio" name="rating" value="star-4" />
            <label for="star-4" title="4 stars">
              <i class="active fa fa-star"></i>
            </label>
            <input id="star-3" type="radio" name="rating" value="star-3" />
            <label class="me-1" for="star-3" title="3 stars">
              <i class="active fa fa-star"></i>
            </label>
            <input id="star-2" type="radio" name="rating" value="star-2" />
            <label class="me-1" for="star-2" title="2 stars">
              <i class="active fa fa-star"></i>
            </label>
            <input id="star-1" type="radio" name="rating" value="star-1" />
            <label class="me-1" for="star-1" title="1 star">
              <i class="active fa fa-star"></i>
            </label>
          </div>
        </div>
        <div class="mb-3">
          <label class="mb-2">Title of your review</label>
          <input
            class="form-control"
            type="text"
            placeholder="If you could say it in one sentence, what would you say?"
          />
        </div>
        <div class="mb-3">
          <label class="mb-2">Your review</label>
          <textarea id="review_desc" maxlength="100" class="form-control"></textarea>

          <div class="d-flex justify-content-between mt-3">
            <small class="text-muted"
              ><span id="chars">100</span> characters remaining</small
            >
          </div>
        </div>
        <hr />
        <div class="mb-3">
          <div class="terms-accept">
            <div class="custom-checkbox">
              <input class="me-1" type="checkbox" id="terms_accept" />
              <label for="terms_accept"
                >I have read and accept
                <a href="javascript:;">Terms &amp; Conditions</a></label
              >
            </div>
          </div>
        </div>
        <div class="submit-section">
          <b-button type="submit" class="btn btn-primary submit-btn">Add Review</b-button>
        </div>
      </form>
      <!-- /Write Review Form -->
    </div>
    <!-- /Write Review -->
  </div>
</template>
