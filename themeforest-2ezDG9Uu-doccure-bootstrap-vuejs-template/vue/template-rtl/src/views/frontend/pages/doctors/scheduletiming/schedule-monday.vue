<template>
    <!-- Monday Slot -->
    <div id="slot_monday" class="tab-pane fade show active">
        <h4 class="card-title d-flex justify-content-between">
            <span>Time Slots</span>
            <router-link class="edit-link" data-bs-toggle="modal" to="#edit_time_slot"><i class="fa fa-edit me-1"></i>Edit</router-link>
        </h4>

        <!-- Slot List -->
        <div class="doc-times">
            <div class="doc-slot-list">
                8:00 pm - 11:30 pm
                <a href="javascript:void(0)" class="delete_schedule">
                    <i class="fa fa-times"></i>
                </a>
            </div>
            <div class="doc-slot-list">
                11:30 pm - 1:30 pm
                <a href="javascript:void(0)" class="delete_schedule">
                    <i class="fa fa-times"></i>
                </a>
            </div>
            <div class="doc-slot-list">
                3:00 pm - 5:00 pm
                <a href="javascript:void(0)" class="delete_schedule">
                    <i class="fa fa-times"></i>
                </a>
            </div>
            <div class="doc-slot-list">
                6:00 pm - 11:00 pm
                <a href="javascript:void(0)" class="delete_schedule">
                    <i class="fa fa-times"></i>
                </a>
            </div>
        </div>
        <!-- /Slot List -->

    </div>
    <!-- /Monday Slot -->

</template>
<script>
export default {
    data() {
        return {
            sorting:["12.00 am","12.30 am","1.00 am","1.30 am"],      
        }
    },
}



</script>