<script>

export default {
  props: {
    name: String,
  }
};

</script>

<template>
  <section>
    <p>{{ name }}</p>
  </section>
</template>

<style scoped>
section {
  background-color: grey;
  width: 500px;
  height: 100px;
  color: white;
  font-size: 32px;
}
</style>
