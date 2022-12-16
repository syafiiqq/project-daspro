<template>
  <v-footer id="footer" app bottom absolute padless dark>
    <v-card
    class="flex"
    flat
    tile
    >
  <v-card-title id="card" class="green darken-4">
    <strong class="subheading">get connectted with on social network!</strong>

    <v-spacer></v-spacer>

    <v-btn
    v-for="icon in icons"
    :key="icon"
    class="mx-3"
    dark
    icons
    >
    <v-icon size="24px">{{ icon }}</v-icon>  
  </v-btn>
  </v-card-title>

  <v-card-actions class="gray darken-3 justify-center">
    @2018 - <strong>Universitas Riau</strong>
  </v-card-actions>
 </v-card>
</v-footer>
</template>

<script> 
 export default {
  data: () => ({
    icons: [
     'mdi-facebook',
     'mdi-twitter',
     'mdi-instagram',
     'mdi-google-plus',
     'mdi-linkedin',
    
    ]
  })
 }
</script>
<style lang="scss">
#footer {
  background-color: darkgreen !important;
}
#card {
  background-color: darkgreen !important;
}
</style>
