<script>
import { ref } from 'vue';

const list = ref(
  [
    {
      name: "Rodrigo",
    },
    {
      name: "Louize"
    }
  ]
) 

export default {
  data() {
    return {
      list: list,
    };
  },
  methods: {
   
  }
};
</script>

<template>
  <main>
    <p v-for="item in list">
     {{ item.name }}
    </p>

  </main> 
</template>


<style scoped>
p {
  color: white;
  font-size: 32px;
}
</style>
