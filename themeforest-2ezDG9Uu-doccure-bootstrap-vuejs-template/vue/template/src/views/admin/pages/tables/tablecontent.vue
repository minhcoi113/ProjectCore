<template>
  <div class="row">
    <div class="col-lg-6">
      <div class="card">
        <div class="card-header">
          <h4 class="card-title">Contextual Classes</h4>
        </div>
        <div class="card-body">
          <div class="table-responsive">
            <b-table :items="items" class="mb-0"></b-table>
          </div>
        </div>
      </div>
    </div>
    <div class="col-lg-6">
      <div class="card">
        <div class="card-header">
          <h4 class="card-title">Responsive Tables</h4>
        </div>
        <div class="card-body">
          <div class="table-responsive">
            <b-table
              :items="tableitems"
              :fields="fields"
              class="table-nowrap mb-0"
            ></b-table>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  data() {
    return {
      fields: [
        {
          key: "num",
          label: "#",
        },
        {
          key: "firstname",
        },
        {
          key: "lastname",
        },
        {
          key: "age",
        },
        {
          key: "city",
        },
        {
          key: "country",
        },
      ],
      items: [
        { firstname: "Default", lastname: "Defaultson", email: "def@somemail.com" },
        {
          firstname: "Primary",
          lastname: "Doe",
          email: "john@example.com",
          _rowVariant: "primary",
        },
        {
          firstname: "Secondary",
          lastname: "Moe",
          email: "mary@example.com",
          _rowVariant: "secondary",
        },
        {
          firstname: "Success",
          lastname: "Dooley",
          email: "july@example.com",
          _rowVariant: "success",
        },
        {
          firstname: "Danger",
          lastname: "Refs",
          email: "bo@example.com",
          _rowVariant: "danger",
        },
        {
          firstname: "Warning",
          lastname: "Activeson",
          email: "act@example.com",
          _rowVariant: "warning",
        },
        {
          firstname: "Info",
          lastname: "Activeson",
          email: "act@example.com",
          _rowVariant: "info",
        },
        {
          firstname: "Light",
          lastname: "Activeson",
          email: "act@example.com",
          _rowVariant: "light",
        },
        {
          firstname: "Dark",
          lastname: "Activeson",
          email: "act@example.com",
          _rowVariant: "dark",
        },
      ],
      tableitems: [
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
        {
          num: "1",
          firstname: "Anna",
          lastname: "Pitt",
          age: "35",
          city: "New York",
          country: "USA",
        },
      ],
    };
  },
};
</script>
