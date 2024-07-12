<template>
  <div class="main-wrapper">
    <adminheader></adminheader>
    <adminsidebar></adminsidebar>

    <!-- Page Wrapper -->
    <div class="page-wrapper">
      <div class="content container-fluid">
        <adminbreadcrumb4 :title="title" :text="text" :text1="text1" :create="create" />

        <div class="row">
          <div class="col-lg-3 col-md-4">
            <h4 class="card-title">Drag & Drop Event</h4>
            <div id="calendar-events" class="mb-3">
              <div class="calendar-events" data-class="bg-info">
                <i class="fa fa-circle text-info"></i> My Event One
              </div>
              <div class="calendar-events" data-class="bg-success">
                <i class="fa fa-circle text-success"></i> My Event Two
              </div>
              <div class="calendar-events" data-class="bg-danger">
                <i class="fa fa-circle text-danger"></i> My Event Three
              </div>
              <div class="calendar-events" data-class="bg-warning">
                <i class="fa fa-circle text-warning"></i> My Event Four
              </div>
            </div>
            <div class="checkbox mb-3">
              <input class="me-2" id="drop-remove" type="checkbox" />
              <label for="drop-remove"> Remove after drop </label>
            </div>
            <a
              href="javascript:void(0)"
              data-bs-toggle="modal"
              data-bs-target="#add_new_event"
              class="btn mb-3 btn-primary w-100"
            >
              <i class="fa fa-plus"></i> Add Category
            </a>
          </div>
          <div class="col-lg-9 col-md-8">
            <div class="card">
              <div class="card-body">
                <div id="calendar"></div>
                <FullCalendar
                  :options="calendarOptions"
                  :events="events"
                  id="calendar-book"
                ></FullCalendar>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div id="add_event" class="modal fade" role="dialog">
      <div class="modal-dialog modal-dialog-centered" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title">Add Event</h5>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></b-button>
          </div>
          <div class="modal-body">
            <form>
              <div class="mb-3">
                <label class="mb-2">Event Name <span class="text-danger">*</span></label>
                <input class="form-control" type="text" />
              </div>
              <div class="mb-3">
                <label class="mb-2">Event Date <span class="text-danger">*</span></label>
                <div class="cal-icon">
                  <datepicker
                    v-model="startdate"
                    placeholder="Choose Date"
                    class="form-control datetimepicker"
                    :editable="true"
                    :clearable="false"
                  />
                </div>
              </div>
              <div class="submit-section">
                <b-button class="btn btn-primary submit-btn">Submit</b-button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
    <!-- /Add Event Modal -->

    <!-- Add Event Modal -->
    <div class="modal fade none-border" id="my_event">
      <div class="modal-dialog modal-dialog-centered">
        <div class="modal-content">
          <div class="modal-header">
            <h4 class="modal-title">Add Event</h4>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-hidden="true"
            ></b-button>
          </div>
          <div class="modal-body"></div>
          <div class="modal-footer justify-content-center">
            <b-button type="button" class="btn btn-success save-event submit-btn">
              Create event
            </b-button>
            <b-button
              type="button"
              class="btn btn-danger delete-event submit-btn"
              data-bs-dismiss="modal"
            >
              Delete
            </b-button>
          </div>
        </div>
      </div>
    </div>
    <!-- /Add Event Modal -->

    <!-- Add Category Modal -->
    <div class="modal fade" id="add_new_event">
      <div class="modal-dialog modal-dialog-centered">
        <div class="modal-content">
          <div class="modal-header">
            <h4 class="modal-title">Add Category</h4>
            <b-button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-hidden="true"
            ></b-button>
          </div>
          <div class="modal-body">
            <form>
              <div class="mb-3">
                <label class="mb-2">Category Name</label>
                <input
                  class="form-control form-white"
                  placeholder="Enter name"
                  type="text"
                  name="category-name"
                />
              </div>
              <div class="mb-0">
                <label class="mb-2">Choose Category Color</label>
                <vue-select :options="Successselect" placeholder="Choose a color..." />
              </div>
              <div class="submit-section">
                <b-button
                  type="button"
                  class="btn btn-primary save-category submit-btn mt-3"
                  data-bs-dismiss="modal"
                >
                  Save
                </b-button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { ref } from "vue";
const currentDate = ref(new Date());
import FullCalendar from "@fullcalendar/vue3";
import dayGridPlugin from "@fullcalendar/daygrid";
import timeGridPlugin from "@fullcalendar/timegrid";
import interactionPlugin from "@fullcalendar/interaction";
export default {
  components: {
    FullCalendar,
  },
  data() {
    return {
      title: "Calendar",
      text: "Dashboard",
      text1: "Calendar",
      create: "Create New",
      startdate: currentDate,
      Successselect: ["Success", "Danger", "Info", "Primary", "Warning", "Inverse"],
      calendarOptions: {
        plugins: [
          dayGridPlugin,
          timeGridPlugin,
          interactionPlugin, // needed for dateClick
        ],
        headerToolbar: {
          left: "prev next today",
          center: "title",
          right: "dayGridMonth,timeGridWeek,timeGridDay",
        },
        events: [
          {
            title: "11:37a Test Event 2",
            start: "2023-07-11",
          },
          {
            title: "9:31a Test Event 4",
            start: "2023-07-15",
          },
          {
            title: "5:44a Test Event 5",
            start: "2023-07-14",
          },
          {
            title: "Event Name 1 4:44a",
            start: "2023-07-13",
          },
          {
            title: "Test Event 3 10:17a",
            start: "2023-07-13",
          },
        ],
        initialView: "dayGridMonth",
        editable: true,
        selectable: true,
        selectMirror: true,
        dayMaxEvents: true,
        weekends: true,
      },
    };
  },
};
</script>
