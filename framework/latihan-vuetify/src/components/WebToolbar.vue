<template>
    <v-toolbar id="toolbar" color="green darken-4" dark>
     <v-app-bar-nav-icon @click.stop="drawer = !drawer">
     <div class="hidden-sm-and-down">
        <v-btn text>Home</v-btn>
        <v-btn text>Profile</v-btn>
        <v-btn text>Unit Lembaga</v-btn>
        <v-btn text>Dokumen</v-btn>
        <v-btn text>Gallery</v-btn>
        <v-btn text>Video profil</v-btn>
        <router-link to="/login">
            <v-btn text>Kontak</v-btn>
        </router-link>
     </div>
     <div class="hidden-sm-and-down">
      <v-navigation-drawer
      v-model="drawer"
      absolute
      temporary
      height="800px">
      <v-list class="pa-1">
        <v-list-tile avatar>
            <v-list-tile-avatar>
                <img src="https://randomuser.me/api/potraits/men/85.jpg">
            </v-list-tile-avatar>

            <v-list-tile-content>
                <v-list-tile-title>John Leider</v-list-tile-title>
            </v-list-tile-content>
        </v-list-tile>
      </v-list>
      <v-list class="pt-0" dense>
        <v-divider></v-divider>

        <v-list-tile
        v-for="item in items"
        :key="item.title">
        <v-list-tile-action>
            <v-icon>{{ item.action }}</v-icon>
        </v-list-tile-action>

        <v-list-tile-content>
            <v-list-tile-title>{{ item.title }}</v-list-tile-title>
        </v-list-tile-content>
        </v-list-tile>
      </v-list>
    </v-navigation-drawer>

     </div>
    </v-app-bar-nav-icon>
    </v-toolbar>
</template>

<script>
    export default {
        data () {
            return {
                drawer: null,
                items: [
                    { title: 'Home', icon: 'home' },
                    { title: 'About', icon: 'help' }
                ]
            }
        }
    }
</script>
<style>
#toolbar {
    background-color: darkgreen;
}
.v-btn {
    background-color: darkgreen;
}
</style>