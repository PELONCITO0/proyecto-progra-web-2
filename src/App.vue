<script setup>
import Boton from './components/ButtonApp.vue'
import CardApp from './components/CardApp.vue'
import EncabezadoApp from './components/EncabezadoApp.vue'
</script>

<template>
  <EncabezadoApp />
  <h1>Lo lograste!</h1>
  <p>
    Visit <a href="https://vuejs.org/" target="_blank" rel="noopener">vuejs.org</a> to read the
    documentation
  </p>

  <Boton/>

  <CardApp titulo="Componente reutilizable" texto="Esta tarjeta es un componente que recibe props y se puede reutilizar cuantas veces sea necesario." />
  <CardApp titulo="Segundo ejemplo" texto="Cada instancia puede mostrar contenido distinto." />
</template>

<style scoped>
</style>
