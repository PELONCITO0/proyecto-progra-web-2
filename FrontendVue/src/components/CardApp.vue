<template>
  <div class="card">
    <h3 class="card-title">{{ titulo }}</h3>
    <p class="card-text">{{ texto }}</p>
  </div>
</template>

<script>
export default {
  name: "CardApp",
  props: {
    titulo: {
      type: String,
      required: true
    },
    texto: {
      type: String,
      default: ""
    }
  }
}
</script>

<style scoped>
.card {
  border: 1px solid #ddd;
  border-radius: 8px;
  padding: 16px;
  max-width: 300px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.card-title {
  margin: 0 0 8px 0;
  color: #2c3e50;
}

.card-text {
  margin: 0;
  color: #555;
}
</style>
