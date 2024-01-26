<script>
import { ref } from "vue";
import axios from "axios";
import Card from "./components/Card.vue"

// dados fixo precisam do ref
// const list = ref(
//   [
//     {
//       name: "Rodrigo",
//     },
//     {
//       name: "Louize"
//     }
//   ]
// )

export default {
  data() {
    return {
      list: null,
      loading: false
    };
  },
  methods: {
    async getList() {
      try {
        this.loading = true
        const res = await axios.get(
          "https://rickandmortyapi.com/api/character"
        );
        this.list = res.data.results;
        this.loading = false

        console.log(this.list);
      } catch (error) {
        this.loading = false

        console.log(error);
      }
    },
  },
  // mounted() {
  //   this.getList();
  // },
  components: {
    Card,
  },
};
</script>

<template>
  <main>


    <button :disabled="loading" @click="getList">Get list</button>
    <p v-if="loading" role="alert">Loading your list</p>
    <div v-else>
      <Card v-for="item in list" :key="item.id" :name="item.name" /> 
              
    </div>
  </main>
</template>

<style scoped>
p {
  color: white;
  font-size: 32px;
}
</style>
