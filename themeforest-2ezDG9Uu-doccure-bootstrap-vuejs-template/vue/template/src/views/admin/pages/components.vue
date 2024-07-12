<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb :title="title" :text="text" :text1="text1" />
        <!-- /Page Header -->

        <div class="comp-sec-wrapper">
          <!-- Avatar -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Avatar</h3>
              <div class="line"></div>
            </div>
            <div class="row">
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Sizing</h4>
                  </div>
                  <div class="card-body">
                    <div class="avatar avatar-xxl me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar avatar-xl me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar avatar-lg me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar avatar-sm me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar avatar-xs">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Avatar With Status</h4>
                  </div>
                  <div class="card-body">
                    <div class="avatar avatar-online me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar avatar-offline me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar avatar-away me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Shape</h4>
                  </div>
                  <div class="card-body">
                    <div class="avatar me-1">
                      <img
                        class="avatar-img rounded"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                    <div class="avatar me-1">
                      <img
                        class="avatar-img rounded-circle"
                        alt="User Image"
                        src="@/assets/admin/img/profiles/avatar-02.jpg"
                      />
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Group</h4>
                  </div>
                  <div class="card-body">
                    <div class="avatar-group">
                      <div class="avatar">
                        <img
                          class="avatar-img rounded-circle border border-white"
                          alt="User Image"
                          src="@/assets/admin/img/profiles/avatar-02.jpg"
                        />
                      </div>
                      <div class="avatar">
                        <img
                          class="avatar-img rounded-circle border border-white"
                          alt="User Image"
                          src="@/assets/admin/img/profiles/avatar-03.jpg"
                        />
                      </div>
                      <div class="avatar">
                        <img
                          class="avatar-img rounded-circle border border-white"
                          alt="User Image"
                          src="@/assets/admin/img/profiles/avatar-04.jpg"
                        />
                      </div>
                      <div class="avatar">
                        <span class="avatar-title rounded-circle border border-white"
                          >CF</span
                        >
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </section>
          <!-- /Avatar -->

          <!-- Alerts -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Alerts</h3>
              <div class="line"></div>
            </div>
            <div class="card">
              <div class="card-body">
                <b-alert show dismissible variant="primary">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="secondary">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="success">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="danger">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="warning">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="info">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="light">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
                <b-alert show dismissible variant="dark">
                  <strong>Holy guacamole!</strong> You should check in on some of those
                  fields below.
                </b-alert>
              </div>
            </div>
          </section>
          <!-- /Alerts -->

          <!-- Breadcrumbs -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Breadcrumbs</h3>
              <div class="line"></div>
            </div>
            <div class="card">
              <div class="card-body">
                <nav aria-label="breadcrumb">
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item active" aria-current="page">Home</li>
                  </ol>
                </nav>
                <nav aria-label="breadcrumb">
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item">
                      <a href="javascript:void(0);">Home</a>
                    </li>
                    <li class="breadcrumb-item active" aria-current="page">Products</li>
                  </ol>
                </nav>
                <nav aria-label="breadcrumb">
                  <ol class="breadcrumb mb-0">
                    <li class="breadcrumb-item">
                      <a href="javascript:void(0);">Home</a>
                    </li>
                    <li class="breadcrumb-item">
                      <a href="javascript:void(0);">Products</a>
                    </li>
                    <li class="breadcrumb-item active" aria-current="page">
                      Accessories
                    </li>
                  </ol>
                </nav>
              </div>
            </div>
          </section>
          <!-- /Breadcrumbs -->

          <!-- Buttons -->
          <section class="comp-section comp-buttons">
            <div class="section-header">
              <h3 class="section-title">Buttons</h3>
              <div class="line"></div>
            </div>
            <div class="card">
              <div class="card-body">
                <h5 class="card-title">Default Button</h5>
                <b-button variant="primary me-1">Primary</b-button>
                <b-button variant="secondary me-1">Secondary</b-button>
                <b-button variant="success me-1">Success</b-button>
                <b-button variant="danger me-1">Danger</b-button>
                <b-button variant="warning me-1">Warning</b-button>
                <b-button variant="info me-1">Info</b-button>
                <b-button variant="light me-1">Light</b-button>
                <b-button variant="dark me-1">Dark</b-button>
                <b-button class="btn-link">Link</b-button>
                <hr />
                <h5 class="card-title">Button Sizes</h5>
                <p>
                  <b-button variant="primary btn-lg me-1">Primary</b-button>
                  <b-button variant="secondary btn-lg me-1">Secondary</b-button>
                  <b-button variant="success btn-lg me-1">Success</b-button>
                  <b-button variant="danger btn-lg me-1">Danger</b-button>
                  <b-button variant="warning btn-lg me-1">Warning</b-button>
                  <b-button variant="info btn-lg me-1">Info</b-button>
                  <b-button variant="light btn-lg me-1">Light</b-button>
                  <b-button variant="dark btn-lg">Dark</b-button>
                </p>
                <p>
                  <b-button variant="primary me-1">Primary</b-button>
                  <b-button variant="secondary me-1">Secondary</b-button>
                  <b-button variant="success me-1">Success</b-button>
                  <b-button variant="danger me-1">Danger</b-button>
                  <b-button variant="warning me-1">Warning</b-button>
                  <b-button variant="info me-1">Info</b-button>
                  <b-button variant="light me-1">Light</b-button>
                  <b-button variant="dark">Dark</b-button>
                </p>
                <p>
                  <b-button size="sm" variant="primary me-1">Primary</b-button>
                  <b-button size="sm" variant="secondary me-1">Secondary</b-button>
                  <b-button size="sm" variant="success me-1">Success</b-button>
                  <b-button size="sm" variant="danger me-1">Danger</b-button>
                  <b-button size="sm" variant="warning me-1">Warning</b-button>
                  <b-button size="sm" variant="info me-1">Info</b-button>
                  <b-button size="sm" variant="light me-1">Light</b-button>
                  <b-button size="sm" variant="dark">Dark</b-button>
                </p>
                <hr />
                <h5 class="card-title">Button Groups</h5>
                <div class="btn-toolbar">
                  <div class="btn-group btn-group-lg">
                    <b-button variant="primary">Left</b-button>
                    <b-button variant="primary">Middle</b-button>
                    <b-button variant="primary">Right</b-button>
                  </div>
                </div>
                <br />
                <div class="btn-toolbar">
                  <div class="btn-group">
                    <b-button variant="primary">Left</b-button>
                    <b-button variant="primary">Middle</b-button>
                    <b-button variant="primary">Right</b-button>
                  </div>
                </div>
                <br />
                <div class="btn-toolbar">
                  <div class="btn-group btn-group-sm">
                    <b-button variant="primary">Left</b-button>
                    <b-button variant="primary">Middle</b-button>
                    <b-button variant="primary">Right</b-button>
                  </div>
                </div>
              </div>
            </div>

            <!-- Rounded Button -->
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Rounded Button</h4>
                <p class="card-text">
                  use <code>.btn-rounded</code> in class <code>.btn</code> class to get
                  Rounded button
                </p>
              </div>
              <div class="card-body">
                <b-button class="btn me-1 btn-rounded btn-primary"> Primary </b-button>
                <b-button class="btn me-1 btn-rounded btn-secondary">
                  Secondary
                </b-button>
                <b-button class="btn me-1 btn-rounded btn-success"> Success </b-button>
                <b-button class="btn me-1 btn-rounded btn-danger"> Danger </b-button>
                <b-button class="btn me-1 btn-rounded btn-warning"> Warning </b-button>
                <b-button class="btn me-1 btn-rounded btn-info">Info</b-button>
                <b-button class="btn me-1 btn-rounded btn-light"> Light </b-button>
                <b-button class="btn btn-rounded btn-dark">Dark</b-button>
                <hr />
                <p>
                  use <code>.btn-rounded</code> in class <code>.btn-outline-*</code> class
                  to get Rounded Outline button
                </p>
                <b-button variant="btn me-1 btn-rounded btn-outline-primary">
                  Primary
                </b-button>
                <b-button variant="btn me-1 btn-rounded btn-outline-secondary">
                  Secondary
                </b-button>
                <b-button variant="btn me-1 btn-rounded btn-outline-success">
                  Sucucess
                </b-button>
                <b-button variant="btn me-1 btn-rounded btn-outline-danger">
                  Danger
                </b-button>
                <b-button variant="btn me-1 btn-rounded btn-outline-warning">
                  Warning
                </b-button>
                <b-button variant="btn me-1 btn-rounded btn-outline-info">
                  Info
                </b-button>
                <b-button variant="btn me-1 btn-rounded btn-outline-light">
                  Light
                </b-button>
                <b-button variant="btn btn-rounded btn-outline-dark"> Dark </b-button>
              </div>
            </div>
            <!-- /Rounded Button -->

            <!-- Outline Buttons -->
            <div class="card">
              <div class="card-header">
                <h4 class="card-title">Outline Buttons</h4>
                <p class="card-text">
                  Use <code>.btn-outline-*</code> class for outline buttons.
                </p>
              </div>
              <div class="card-body">
                <div class="row row-sm align-items-center">
                  <div class="col-12 col-xl mb-3 mb-xl-0">Normal</div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-primary btn-block w-100">Primary</b-button>
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-secondary btn-block w-100"
                      >Secondary</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-success btn-block w-100">Success</b-button>
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-warning btn-block w-100">Warning</b-button>
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-danger btn-block w-100">Danger</b-button>
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-info btn-block w-100">Info</b-button>
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-light btn-block w-100">Light</b-button>
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-dark btn-block w-100">Dark</b-button>
                  </div>
                </div>
                <div class="row row-sm align-items-center mt-3">
                  <div class="col-12 col-xl mb-3 mb-xl-0">Active</div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-primary btn-block active w-100"
                      >Primary</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-secondary btn-block active w-100"
                      >Secondary</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-success btn-block active w-100"
                      >Success</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-warning btn-block active w-100"
                      >Warning</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-danger btn-block active w-100"
                      >Danger</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-info btn-block active w-100"
                      >Info</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-light btn-block active w-100"
                      >Light</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button variant="outline-dark btn-block active w-100"
                      >Dark</b-button
                    >
                  </div>
                </div>
                <div class="row row-sm align-items-center mt-3">
                  <div class="col-12 col-xl mb-3 mb-xl-0">Disabled</div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-primary btn-block w-100"
                      >Primary</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-secondary btn-block w-100"
                      >Secondary</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-success btn-block w-100"
                      >Success</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-warning btn-block w-100"
                      >Warning</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-danger btn-block w-100"
                      >Danger</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-info btn-block w-100"
                      >Info</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-light btn-block w-100"
                      >Light</b-button
                    >
                  </div>
                  <div class="col-6 col-sm-4 col-md-2 col-xl mb-3 mb-xl-0">
                    <b-button disabled variant="outline-dark btn-block w-100"
                      >Dark</b-button
                    >
                  </div>
                </div>
              </div>
            </div>
            <!-- /Outline Buttons -->

            <!-- Progress Button -->
            <div class="card mb-4">
              <div class="card-header">
                <h4 class="card-title">Progress Button</h4>
              </div>
              <div class="card-body">
                <b-button variant="primary me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Primary</b-button
                >
                <b-button variant="secondary me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Secondary</b-button
                >
                <b-button variant="success me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Success</b-button
                >
                <b-button variant="danger me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Danger</b-button
                >
                <b-button variant="warning me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Warning</b-button
                >
                <b-button variant="info me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Info</b-button
                >
                <b-button variant="dark me-1"
                  ><span
                    class="spinner-border spinner-border-sm me-2"
                    role="status"
                  ></span
                  >Dark</b-button
                >
              </div>
            </div>
            <!-- /Progress Button -->
          </section>
          <!-- Buttons -->

          <!-- Cards -->
          <section class="comp-section comp-cards">
            <div class="section-header">
              <h3 class="section-title">Cards</h3>
              <div class="line"></div>
            </div>

            <div class="row">
              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <img
                    alt="Card Image"
                    src="@/assets/admin/img/img-01.jpg"
                    class="card-img-top"
                  />
                  <div class="card-header">
                    <h5 class="card-title mb-0">Card with image and links</h5>
                  </div>
                  <div class="card-body">
                    <p class="card-text">
                      Some quick example text to build on the card title and make up the
                      bulk of the card's content.
                    </p>
                    <a class="card-link" href="javascript:void(0);">Card link</a>
                    <a class="card-link" href="javascript:void(0);">Another link</a>
                  </div>
                </div>
              </div>

              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <img
                    alt="Card Image"
                    src="@/assets/admin/img/img-01.jpg"
                    class="card-img-top"
                  />
                  <div class="card-header">
                    <h5 class="card-title mb-0">Card with image and button</h5>
                  </div>
                  <div class="card-body">
                    <p class="card-text">
                      Some quick example text to build on the card title and make up the
                      bulk of the card's content.
                    </p>
                    <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                  </div>
                </div>
              </div>

              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <img
                    alt="Card Image"
                    src="@/assets/admin/img/img-01.jpg"
                    class="card-img-top"
                  />
                  <div class="card-header">
                    <h5 class="card-title mb-0">Card with image and list</h5>
                  </div>
                  <ul class="list-group list-group-flush">
                    <li class="list-group-item">Cras justo odio</li>
                    <li class="list-group-item">Dapibus ac facilisis in</li>
                    <li class="list-group-item">Vestibulum at eros</li>
                  </ul>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h5 class="card-title mb-0">Card with links</h5>
                  </div>
                  <div class="card-body">
                    <p class="card-text">
                      Some quick example text to build on the card title and make up the
                      bulk of the card's content.
                    </p>
                    <a class="card-link" href="javascript:void(0);">Card link</a>
                    <a class="card-link" href="javascript:void(0);">Another link</a>
                  </div>
                </div>
              </div>

              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h5 class="card-title mb-0">Card with button</h5>
                  </div>
                  <div class="card-body">
                    <p class="card-text">
                      Some quick example text to build on the card title and make up the
                      bulk of the card's content.
                    </p>
                    <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                  </div>
                </div>
              </div>

              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h5 class="card-title mb-0">Card with list</h5>
                  </div>
                  <ul class="list-group list-group-flush">
                    <li class="list-group-item">Cras justo odio</li>
                    <li class="list-group-item">Dapibus ac facilisis in</li>
                    <li class="list-group-item">Vestibulum at eros</li>
                  </ul>
                </div>
              </div>
            </div>

            <div class="row">
              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">This is my header</div>
                  <div class="card-body">
                    <h5 class="card-title">Special title treatment</h5>
                    <p class="card-text">
                      Some quick example text to build on the card title and make up the
                      bulk of the card's content.
                    </p>
                  </div>
                  <div class="card-footer text-muted">This is my footer</div>
                </div>
              </div>

              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <ul role="tablist" class="nav nav-tabs card-header-tabs float-end">
                      <li class="nav-item">
                        <a href="#tab-1" data-bs-toggle="tab" class="nav-link active"
                          >Active</a
                        >
                      </li>
                      <li class="nav-item">
                        <a href="#tab-2" data-bs-toggle="tab" class="nav-link">Link</a>
                      </li>
                      <li class="nav-item">
                        <a href="#tab-3" data-bs-toggle="tab" class="nav-link disabled"
                          >Disabled</a
                        >
                      </li>
                    </ul>
                  </div>
                  <div class="card-body">
                    <div class="tab-content pt-0">
                      <div role="tabpanel" id="tab-1" class="tab-pane fade show active">
                        <h5 class="card-title">Card with tabs</h5>
                        <p class="card-text">
                          Some quick example text to build on the card title and make up
                          the bulk of the card's content.
                        </p>
                        <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                      </div>
                      <div role="tabpanel" id="tab-2" class="tab-pane fade text-center">
                        <h5 class="card-title">Card with tabs</h5>
                        <p class="card-text">
                          Some quick example text to build on the card title and make up
                          the bulk of the card's content.
                        </p>
                        <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                      </div>
                      <div role="tabpanel" id="tab-3" class="tab-pane fade">
                        <h5 class="card-title">Card with tabs</h5>
                        <p class="card-text">
                          Some quick example text to build on the card title and make up
                          the bulk of the card's content.
                        </p>
                        <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-12 col-md-6 col-lg-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <ul role="tablist" class="nav nav-pills card-header-pills float-end">
                      <li class="nav-item">
                        <a href="#tab-4" data-bs-toggle="tab" class="nav-link active"
                          >Active</a
                        >
                      </li>
                      <li class="nav-item">
                        <a href="#tab-5" data-bs-toggle="tab" class="nav-link">Link</a>
                      </li>
                      <li class="nav-item">
                        <a href="#tab-6" data-bs-toggle="tab" class="nav-link disabled"
                          >Disabled</a
                        >
                      </li>
                    </ul>
                  </div>
                  <div class="card-body">
                    <div class="tab-content pt-0">
                      <div role="tabpanel" id="tab-4" class="tab-pane fade show active">
                        <h5 class="card-title">Card with pills</h5>
                        <p class="card-text">
                          Some quick example text to build on the card title and make up
                          the bulk of the card's content.
                        </p>
                        <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                      </div>
                      <div role="tabpanel" id="tab-5" class="tab-pane fade text-center">
                        <h5 class="card-title">Card with pills</h5>
                        <p class="card-text">
                          Some quick example text to build on the card title and make up
                          the bulk of the card's content.
                        </p>
                        <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                      </div>
                      <div role="tabpanel" id="tab-6" class="tab-pane fade">
                        <h5 class="card-title">Card with pills</h5>
                        <p class="card-text">
                          Some quick example text to build on the card title and make up
                          the bulk of the card's content.
                        </p>
                        <a variant="primary" href="javascript:void(0);">Go somewhere</a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </section>
          <!-- /Cards -->

          <!-- Dropdowns -->
          <section class="comp-section comp-dropdowns">
            <div class="section-header">
              <h3 class="section-title">Dropdowns</h3>
              <div class="line"></div>
            </div>
            <div class="card bg-white">
              <div class="card-body">
                <h5 class="card-title">Dropdowns within Text</h5>
                <div class="dropdown">
                  <a
                    class="dropdown-toggle"
                    href="javascript:void(0);"
                    role="button"
                    data-bs-toggle="dropdown"
                    aria-expanded="false"
                  >
                    Dropdown
                  </a>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                  </div>
                </div>
                <hr />
                <h5 class="card-title">Dropdowns within Buttons</h5>
                <div class="btn-group">
                  <b-button
                    type="button"
                    class="btn me-1 btn-primary dropdown-toggle"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    Action
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button
                    type="button"
                    class="btn me-1 btn-secondary dropdown-toggle"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    Action
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button
                    type="button"
                    class="btn me-1 btn-info dropdown-toggle"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    Action
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button
                    type="button"
                    class="btn me-1 btn-success dropdown-toggle"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    Action
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button
                    type="button"
                    class="btn me-1 btn-warning dropdown-toggle"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    Action
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button
                    type="button"
                    class="btn me-1 btn-danger dropdown-toggle"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    Action
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <hr />
                <h5 class="card-title">Split button dropdowns</h5>
                <div class="btn-group">
                  <b-button type="button" class="btn btn-primary">Action</b-button>
                  <b-button
                    type="button"
                    class="btn me-1 btn-primary dropdown-toggle dropdown-toggle-split"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span class="sr-only">Toggle Dropdown</span>
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button type="button" class="btn btn-secondary">Action</b-button>
                  <b-button
                    type="button"
                    class="btn me-1 btn-secondary dropdown-toggle dropdown-toggle-split"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span class="sr-only">Toggle Dropdown</span>
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button type="button" class="btn btn-info">Action</b-button>
                  <b-button
                    type="button"
                    class="btn me-1 btn-info dropdown-toggle dropdown-toggle-split"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span class="sr-only">Toggle Dropdown</span>
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button type="button" class="btn btn-success">Action</b-button>
                  <b-button
                    type="button"
                    class="btn me-1 btn-success dropdown-toggle dropdown-toggle-split"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span class="sr-only">Toggle Dropdown</span>
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button type="button" class="btn btn-warning">Action</b-button>
                  <b-button
                    type="button"
                    class="btn me-1 btn-warning dropdown-toggle dropdown-toggle-split"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span class="sr-only">Toggle Dropdown</span>
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
                <div class="btn-group">
                  <b-button type="button" class="btn btn-danger">Action</b-button>
                  <b-button
                    type="button"
                    class="btn btn-danger dropdown-toggle dropdown-toggle-split"
                    data-bs-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span class="sr-only">Toggle Dropdown</span>
                  </b-button>
                  <div class="dropdown-menu">
                    <a class="dropdown-item" href="javascript:void(0);">Action</a>
                    <a class="dropdown-item" href="javascript:void(0);">Another action</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="javascript:void(0);">Separated link</a>
                  </div>
                </div>
              </div>
            </div>
          </section>
          <!-- /Dropdowns -->

          <!-- Pagination -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Pagination</h3>
              <div class="line"></div>
            </div>
            <div class="card">
              <div class="card-body">
                <div>
                  <ul class="pagination">
                    <li class="page-item disabled">
                      <a class="page-link" href="javascript:void(0);" tabindex="-1"
                        >Previous</a
                      >
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">1</a>
                    </li>
                    <li class="page-item active">
                      <a class="page-link" href="javascript:void(0);"
                        >2 <span class="visually-hidden">(current)</span></a
                      >
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">3</a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">Next</a>
                    </li>
                  </ul>
                </div>
                <div>
                  <ul class="pagination">
                    <li class="page-item">
                      <a
                        class="page-link"
                        href="javascript:void(0);"
                        aria-label="Previous"
                      >
                        <span aria-hidden="true">&laquo;</span>
                        <span class="visually-hidden">Previous</span>
                      </a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">1</a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">2</a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">3</a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);" aria-label="Next">
                        <span aria-hidden="true">&raquo;</span>
                        <span class="visually-hidden">Next</span>
                      </a>
                    </li>
                  </ul>
                </div>
                <div>
                  <ul class="pagination pagination-lg">
                    <li class="page-item disabled">
                      <a class="page-link" href="javascript:void(0);" tabindex="-1"
                        >Previous</a
                      >
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">1</a>
                    </li>
                    <li class="page-item active">
                      <a class="page-link" href="javascript:void(0);"
                        >2 <span class="visually-hidden">(current)</span></a
                      >
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">3</a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">Next</a>
                    </li>
                  </ul>
                </div>

                <div>
                  <ul class="pagination pagination-sm mb-0">
                    <li class="page-item disabled">
                      <a class="page-link" href="javascript:void(0);" tabindex="-1"
                        >Previous</a
                      >
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">1</a>
                    </li>
                    <li class="page-item active">
                      <a class="page-link" href="javascript:void(0);"
                        >2 <span class="visually-hidden">(current)</span></a
                      >
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">3</a>
                    </li>
                    <li class="page-item">
                      <a class="page-link" href="javascript:void(0);">Next</a>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
          </section>
          <!-- /Pagination -->

          <!-- Progress -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Progress</h3>
              <div class="line"></div>
            </div>
            <div class="progress-example card">
              <div class="card-header">
                <h4 class="card-title">Large Progress Bars</h4>
              </div>
              <div class="card-body pb-0">
                <div class="row">
                  <div class="col-md-6">
                    <div>
                      <div class="progress progress-lg">
                        <div
                          class="progress-bar"
                          role="progressbar"
                          style="width: 10%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-lg">
                        <div
                          class="progress-bar bg-success"
                          role="progressbar"
                          style="width: 25%"
                          aria-valuenow="25"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-lg">
                        <div
                          class="progress-bar bg-info"
                          role="progressbar"
                          style="width: 50%"
                          aria-valuenow="50"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-lg">
                        <div
                          class="progress-bar bg-warning"
                          role="progressbar"
                          style="width: 75%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-lg">
                        <div
                          class="progress-bar bg-danger"
                          role="progressbar"
                          style="width: 100%"
                          aria-valuenow="100"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="progress progress-lg">
                      <div
                        class="progress-bar progress-bar-striped"
                        role="progressbar"
                        style="width: 10%"
                        aria-valuenow="10"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-lg">
                      <div
                        class="progress-bar progress-bar-striped bg-success"
                        role="progressbar"
                        style="width: 25%"
                        aria-valuenow="25"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-lg">
                      <div
                        class="progress-bar progress-bar-striped bg-info"
                        role="progressbar"
                        style="width: 50%"
                        aria-valuenow="50"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-lg">
                      <div
                        class="progress-bar progress-bar-striped bg-warning"
                        role="progressbar"
                        style="width: 75%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-lg">
                      <div
                        class="progress-bar progress-bar-striped bg-danger"
                        role="progressbar"
                        style="width: 100%"
                        aria-valuenow="100"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="progress-example card">
              <div class="card-header">
                <h4 class="card-title">Default Progress Bars</h4>
              </div>
              <div class="card-body pb-0">
                <div class="row">
                  <div class="col-md-6">
                    <div class="progress">
                      <div
                        class="progress-bar"
                        role="progressbar"
                        style="width: 10%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar bg-success"
                        role="progressbar"
                        style="width: 25%"
                        aria-valuenow="25"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar bg-info"
                        role="progressbar"
                        style="width: 50%"
                        aria-valuenow="50"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar bg-warning"
                        role="progressbar"
                        style="width: 75%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar bg-danger"
                        role="progressbar"
                        style="width: 100%"
                        aria-valuenow="100"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="progress">
                      <div
                        class="progress-bar progress-bar-striped"
                        role="progressbar"
                        style="width: 10%"
                        aria-valuenow="10"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar progress-bar-striped bg-success"
                        role="progressbar"
                        style="width: 25%"
                        aria-valuenow="25"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar progress-bar-striped bg-info"
                        role="progressbar"
                        style="width: 50%"
                        aria-valuenow="50"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar progress-bar-striped bg-warning"
                        role="progressbar"
                        style="width: 75%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress">
                      <div
                        class="progress-bar progress-bar-striped bg-danger"
                        role="progressbar"
                        style="width: 100%"
                        aria-valuenow="100"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="progress-example card">
              <div class="card-header">
                <h4 class="card-title">Medium Progress Bars</h4>
              </div>
              <div class="card-body pb-0">
                <div class="row">
                  <div class="col-md-6">
                    <div>
                      <div class="progress progress-md">
                        <div
                          class="progress-bar"
                          role="progressbar"
                          style="width: 10%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-md">
                        <div
                          class="progress-bar bg-success"
                          role="progressbar"
                          style="width: 25%"
                          aria-valuenow="25"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-md">
                        <div
                          class="progress-bar bg-info"
                          role="progressbar"
                          style="width: 50%"
                          aria-valuenow="50"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-md">
                        <div
                          class="progress-bar bg-warning"
                          role="progressbar"
                          style="width: 75%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-md">
                        <div
                          class="progress-bar bg-danger"
                          role="progressbar"
                          style="width: 100%"
                          aria-valuenow="100"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="progress progress-md">
                      <div
                        class="progress-bar progress-bar-striped"
                        role="progressbar"
                        style="width: 10%"
                        aria-valuenow="10"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-md">
                      <div
                        class="progress-bar progress-bar-striped bg-success"
                        role="progressbar"
                        style="width: 25%"
                        aria-valuenow="25"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-md">
                      <div
                        class="progress-bar progress-bar-striped bg-info"
                        role="progressbar"
                        style="width: 50%"
                        aria-valuenow="50"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-md">
                      <div
                        class="progress-bar progress-bar-striped bg-warning"
                        role="progressbar"
                        style="width: 75%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-md">
                      <div
                        class="progress-bar progress-bar-striped bg-danger"
                        role="progressbar"
                        style="width: 100%"
                        aria-valuenow="100"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="progress-example card">
              <div class="card-header">
                <h4 class="card-title">Small Progress Bars</h4>
              </div>
              <div class="card-body pb-0">
                <div class="row">
                  <div class="col-md-6">
                    <div>
                      <div class="progress progress-sm">
                        <div
                          class="progress-bar"
                          role="progressbar"
                          style="width: 10%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-sm">
                        <div
                          class="progress-bar bg-success"
                          role="progressbar"
                          style="width: 25%"
                          aria-valuenow="25"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-sm">
                        <div
                          class="progress-bar bg-info"
                          role="progressbar"
                          style="width: 50%"
                          aria-valuenow="50"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-sm">
                        <div
                          class="progress-bar bg-warning"
                          role="progressbar"
                          style="width: 75%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-sm">
                        <div
                          class="progress-bar bg-danger"
                          role="progressbar"
                          style="width: 100%"
                          aria-valuenow="100"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="progress progress-sm">
                      <div
                        class="progress-bar progress-bar-striped"
                        role="progressbar"
                        style="width: 10%"
                        aria-valuenow="10"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-sm">
                      <div
                        class="progress-bar progress-bar-striped bg-success"
                        role="progressbar"
                        style="width: 25%"
                        aria-valuenow="25"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-sm">
                      <div
                        class="progress-bar progress-bar-striped bg-info"
                        role="progressbar"
                        style="width: 50%"
                        aria-valuenow="50"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-sm">
                      <div
                        class="progress-bar progress-bar-striped bg-warning"
                        role="progressbar"
                        style="width: 75%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-sm">
                      <div
                        class="progress-bar progress-bar-striped bg-danger"
                        role="progressbar"
                        style="width: 100%"
                        aria-valuenow="100"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="progress-example card">
              <div class="card-header">
                <h4 class="card-title">Extra Small Progress Bars</h4>
              </div>
              <div class="card-body pb-0">
                <div class="row">
                  <div class="col-md-6">
                    <div>
                      <div class="progress progress-xs">
                        <div
                          class="progress-bar w-75"
                          role="progressbar"
                          style="width: 10%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-xs">
                        <div
                          class="progress-bar bg-success"
                          role="progressbar"
                          style="width: 25%"
                          aria-valuenow="25"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-xs">
                        <div
                          class="progress-bar bg-info"
                          role="progressbar"
                          style="width: 50%"
                          aria-valuenow="50"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-xs">
                        <div
                          class="progress-bar bg-warning"
                          role="progressbar"
                          style="width: 75%"
                          aria-valuenow="75"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                      <div class="progress progress-xs">
                        <div
                          class="progress-bar bg-danger"
                          role="progressbar"
                          style="width: 100%"
                          aria-valuenow="100"
                          aria-valuemin="0"
                          aria-valuemax="100"
                        ></div>
                      </div>
                    </div>
                  </div>
                  <div class="col-md-6">
                    <div class="progress progress-xs">
                      <div
                        class="progress-bar progress-bar-striped"
                        role="progressbar"
                        style="width: 10%"
                        aria-valuenow="10"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-xs">
                      <div
                        class="progress-bar progress-bar-striped bg-success"
                        role="progressbar"
                        style="width: 25%"
                        aria-valuenow="25"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-xs">
                      <div
                        class="progress-bar progress-bar-striped bg-info"
                        role="progressbar"
                        style="width: 50%"
                        aria-valuenow="50"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-xs">
                      <div
                        class="progress-bar progress-bar-striped bg-warning"
                        role="progressbar"
                        style="width: 75%"
                        aria-valuenow="75"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                    <div class="progress progress-xs">
                      <div
                        class="progress-bar progress-bar-striped bg-danger"
                        role="progressbar"
                        style="width: 100%"
                        aria-valuenow="100"
                        aria-valuemin="0"
                        aria-valuemax="100"
                      ></div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </section>
          <!-- /Progress -->

          <!-- Tabs -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Tabs</h3>
              <div class="line"></div>
            </div>
            <div class="row">
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Basic tabs</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs">
                      <li class="nav-item">
                        <a class="nav-link active" href="#basictab1" data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#basictab2" data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#basictab3" data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="basictab1">Tab content 1</div>
                      <div class="tab-pane" id="basictab2">Tab content 2</div>
                      <div class="tab-pane" id="basictab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Basic justified tabs</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-justified">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#basic-justified-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#basic-justified-tab2"
                          data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item dropdown">
                        <a
                          href="javascript:;"
                          class="dropdown-toggle nav-link"
                          data-bs-toggle="dropdown"
                          >Dropdown</a
                        >
                        <div class="dropdown-menu dropdown-menu-end">
                          <a
                            class="dropdown-item"
                            href="#basic-justified-tab3"
                            data-bs-toggle="tab"
                            >Dropdown 1</a
                          >
                          <a
                            class="dropdown-item"
                            href="#basic-justified-tab4"
                            data-bs-toggle="tab"
                            >Dropdown 2</a
                          >
                        </div>
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="basic-justified-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="basic-justified-tab2">Tab content 2</div>
                      <div class="tab-pane" id="basic-justified-tab3">Tab content 3</div>
                      <div class="tab-pane" id="basic-justified-tab4">Tab content 4</div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="row">
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Top line tabs</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-top">
                      <li class="nav-item">
                        <a class="nav-link active" href="#top-tab1" data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#top-tab2" data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#top-tab3" data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="top-tab1">Tab content 1</div>
                      <div class="tab-pane" id="top-tab2">Tab content 2</div>
                      <div class="tab-pane" id="top-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>

              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Top line justified</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-top nav-justified">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#top-justified-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#top-justified-tab2"
                          data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#top-justified-tab3"
                          data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="top-justified-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="top-justified-tab2">Tab content 2</div>

                      <div class="tab-pane" id="top-justified-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>
            </div>

            <div class="row">
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Bottom line tabs</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-bottom">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#bottom-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#bottom-tab2" data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#bottom-tab3" data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>

                    <div class="tab-content">
                      <div class="tab-pane show active" id="bottom-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="bottom-tab2">Tab content 2</div>
                      <div class="tab-pane" id="bottom-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Bottom line justified</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-bottom nav-justified">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#bottom-justified-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#bottom-justified-tab2"
                          data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#bottom-justified-tab3"
                          data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="bottom-justified-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="bottom-justified-tab2">Tab content 2</div>
                      <div class="tab-pane" id="bottom-justified-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Solid tabs</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-solid">
                      <li class="nav-item">
                        <a class="nav-link active" href="#solid-tab1" data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#solid-tab2" data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="#solid-tab3" data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="solid-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="solid-tab2">Tab content 2</div>
                      <div class="tab-pane" id="solid-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>

              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Solid justified</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-solid nav-justified">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#solid-justified-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#solid-justified-tab2"
                          data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#solid-justified-tab3"
                          data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="solid-justified-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="solid-justified-tab2">Tab content 2</div>
                      <div class="tab-pane" id="solid-justified-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Solid Rounded</h4>
                  </div>
                  <div class="card-body">
                    <ul class="nav nav-tabs nav-tabs-solid nav-tabs-rounded">
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#solid-rounded-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#solid-rounded-tab2"
                          data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#solid-rounded-tab3"
                          data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="solid-rounded-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="solid-rounded-tab2">Tab content 2</div>
                      <div class="tab-pane" id="solid-rounded-tab3">Tab content 3</div>
                    </div>
                  </div>
                </div>
              </div>
              <div class="col-md-6">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Rounded justified</h4>
                  </div>
                  <div class="card-body">
                    <ul
                      class="nav nav-tabs nav-tabs-solid nav-tabs-rounded nav-justified"
                    >
                      <li class="nav-item">
                        <a
                          class="nav-link active"
                          href="#solid-rounded-justified-tab1"
                          data-bs-toggle="tab"
                          >Home</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#solid-rounded-justified-tab2"
                          data-bs-toggle="tab"
                          >Profile</a
                        >
                      </li>
                      <li class="nav-item">
                        <a
                          class="nav-link"
                          href="#solid-rounded-justified-tab3"
                          data-bs-toggle="tab"
                          >Messages</a
                        >
                      </li>
                    </ul>
                    <div class="tab-content">
                      <div class="tab-pane show active" id="solid-rounded-justified-tab1">
                        Tab content 1
                      </div>
                      <div class="tab-pane" id="solid-rounded-justified-tab2">
                        Tab content 2
                      </div>
                      <div class="tab-pane" id="solid-rounded-justified-tab3">
                        Tab content 3
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </section>
          <!-- /Tabs -->

          <!-- Typography -->
          <section class="comp-section">
            <div class="section-header">
              <h3 class="section-title">Typography</h3>
              <div class="line"></div>
            </div>

            <div class="row">
              <div class="col-md-12">
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Headings</h4>
                  </div>
                  <div class="card-body">
                    <h1>h1. Bootstrap heading</h1>
                    <h2>h2. Bootstrap heading</h2>
                    <h3>h3. Bootstrap heading</h3>
                    <h4>h4. Bootstrap heading</h4>
                    <h5>h5. Bootstrap heading</h5>
                    <h6>h6. Bootstrap heading</h6>
                  </div>
                </div>
                <div class="card">
                  <div class="card-header">
                    <h4 class="card-title">Blockquotes</h4>
                  </div>
                  <div class="card-body">
                    <blockquote>
                      <p class="mb-0">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer
                        posuere erat a ante.
                      </p>
                    </blockquote>
                    <blockquote class="blockquote mb-0">
                      <p class="mb-0">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer
                        posuere erat a ante.
                      </p>
                    </blockquote>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h4 class="card-title">Text element</h4>
                  </div>
                  <div class="card-body">
                    <p>You can use the mark tag to <mark>highlight</mark> text.</p>
                    <p>
                      <del>This line of text is meant to be treated as deleted text.</del>
                    </p>
                    <p>
                      <s
                        >This line of text is meant to be treated as no longer
                        accurate.</s
                      >
                    </p>
                    <p>
                      <ins
                        >This line of text is meant to be treated as an addition to the
                        document.</ins
                      >
                    </p>
                    <p><u>This line of text will render as underlined</u></p>
                    <p>
                      <small
                        >This line of text is meant to be treated as fine print.</small
                      >
                    </p>
                    <p><strong>This line rendered as bold text.</strong></p>
                    <p><em>This line rendered as italicized text.</em></p>
                    <p class="text-monospace mb-0">This is in monospace</p>
                  </div>
                </div>
              </div>
              <div class="col-md-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h4 class="card-title">Coloured Link</h4>
                  </div>
                  <div class="card-body">
                    <p class="text-primary">.text-primary</p>
                    <p class="text-secondary">.text-secondary</p>
                    <p class="text-success">.text-success</p>
                    <p class="text-danger">.text-danger</p>
                    <p class="text-warning">.text-warning</p>
                    <p class="text-info">.text-info</p>
                    <p class="text-light bg-dark">.text-light</p>
                    <p class="text-dark">.text-dark</p>
                    <p class="text-muted">.text-muted</p>
                    <p class="text-white bg-dark mb-0">.text-white</p>
                  </div>
                </div>
              </div>
              <div class="col-md-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h4 class="card-title">Coloured text</h4>
                  </div>
                  <div class="card-body">
                    <p>
                      <a href="javascript:void(0);" class="text-primary">Primary link</a>
                    </p>
                    <p>
                      <a href="javascript:void(0);" class="text-secondary"
                        >Secondary link</a
                      >
                    </p>
                    <p>
                      <a href="javascript:void(0);" class="text-success">Success link</a>
                    </p>
                    <p>
                      <a href="javascript:void(0);" class="text-danger">Danger link</a>
                    </p>
                    <p>
                      <a href="javascript:void(0);" class="text-warning">Warning link</a>
                    </p>
                    <p><a href="javascript:void(0);" class="text-info">Info link</a></p>
                    <p>
                      <a href="javascript:void(0);" class="text-light bg-dark"
                        >Light link</a
                      >
                    </p>
                    <p><a href="javascript:void(0);" class="text-dark">Dark link</a></p>
                    <p><a href="javascript:void(0);" class="text-muted">Muted link</a></p>
                    <p>
                      <a href="javascript:void(0);" class="text-white bg-dark mb-0"
                        >White link</a
                      >
                    </p>
                  </div>
                </div>
              </div>
            </div>
            <div class="row">
              <div class="col-md-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h4 class="card-title">Bullet Lists</h4>
                  </div>
                  <div class="card-body">
                    <ul class="mb-0">
                      <li>Lorem ipsum dolor sit amet</li>
                      <li>Consectetur adipiscing elit</li>
                      <li>Integer molestie lorem at massa</li>
                      <li>Facilisis in pretium nisl aliquet</li>
                      <li>
                        Nulla volutpat aliquam velit
                        <ul>
                          <li>Phasellus iaculis neque</li>
                          <li>Purus sodales ultricies</li>
                          <li>Vestibulum laoreet porttitor sem</li>
                          <li>Ac tristique libero volutpat at</li>
                        </ul>
                      </li>
                      <li>Faucibus porta lacus fringilla vel</li>
                      <li>Aenean sit amet erat nunc</li>
                      <li>Eget porttitor lorem</li>
                    </ul>
                  </div>
                </div>
              </div>
              <div class="col-md-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h4 class="card-title">Bullet Lists</h4>
                  </div>
                  <div class="card-body">
                    <ol class="mb-0">
                      <li>Lorem ipsum dolor sit amet</li>
                      <li>Consectetur adipiscing elit</li>
                      <li>Integer molestie lorem at massa</li>
                      <li>Facilisis in pretium nisl aliquet</li>
                      <li>
                        Nulla volutpat aliquam velit
                        <ul>
                          <li>Phasellus iaculis neque</li>
                          <li>Purus sodales ultricies</li>
                          <li>Vestibulum laoreet porttitor sem</li>
                          <li>Ac tristique libero volutpat at</li>
                        </ul>
                      </li>
                      <li>Faucibus porta lacus fringilla vel</li>
                      <li>Aenean sit amet erat nunc</li>
                      <li>Eget porttitor lorem</li>
                    </ol>
                  </div>
                </div>
              </div>
              <div class="col-md-4 d-flex">
                <div class="card flex-fill">
                  <div class="card-header">
                    <h4 class="card-title">Unstyled Lists</h4>
                  </div>
                  <div class="card-body">
                    <ul class="list-unstyled mb-0">
                      <li>Lorem ipsum dolor sit amet</li>
                      <li>Consectetur adipiscing elit</li>
                      <li>Integer molestie lorem at massa</li>
                      <li>Facilisis in pretium nisl aliquet</li>
                      <li>
                        Nulla volutpat aliquam velit
                        <ul>
                          <li>Phasellus iaculis neque</li>
                          <li>Purus sodales ultricies</li>
                          <li>Vestibulum laoreet porttitor sem</li>
                          <li>Ac tristique libero volutpat at</li>
                        </ul>
                      </li>
                      <li>Faucibus porta lacus fringilla vel</li>
                      <li>Aenean sit amet erat nunc</li>
                      <li>Eget porttitor lorem</li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </section>
          <!-- /Typography -->
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: "Components",
      text: "Dashboard",
      text1: "Components",
    };
  },
};
</script>
