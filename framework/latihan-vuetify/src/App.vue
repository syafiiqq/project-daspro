<template>
  <div id="app">
    <img src="./assets/logounri.png" height="75" width="550">
    <web-toolbar>
      <web-login></web-login>
    </web-toolbar> 
       <router-view/>
       <web-home></web-home>
       <web-footer></web-footer>   
  </div>
</template>

<script>
import WebFooter from './components/WebFooter.vue'
import WebToolbar from './components/WebToolbar.vue'
import WebHome from './components/WebHome.vue'
import WebLogin from './components/WebLogin.vue'

export default {
  name: 'App',
  components: { WebFooter, WebToolbar, WebHome, WebLogin}
}
</script>

<style></style>
