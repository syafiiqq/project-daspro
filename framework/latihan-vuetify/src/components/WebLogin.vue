<template>
    <v-container>
        <v-form v-model="valid">
          <v-text-field
            v-model="name"
            :rules="nameRules"
            :counter="10"
            label="Name"
            required></v-text-field>
            <v-text-field
            v-model="email"
            :rules="emailRules"
            :counter="10"
            label="E-mail"
            required></v-text-field>
            <v-text-field 
            v-model="pesan"
            label="Pesan"
            multi-line></v-text-field>
        </v-form>
    </v-container>
</template>

<script>
export default {
    data: () => ({
        valid: true,
        name: '',
        nameRules: [
          v => !!v || 'Name is required',
          v => (v && v.length <= 10) || 'Name must be less than 10 characters',
        ],
        email: '',
        emailRules: [
          v => !!v || 'E-mail is required',
          v => /.+@.+/.test(v) || 'E-mail must be valid',
        ],
        pesan: '',
      }),
}
</script>