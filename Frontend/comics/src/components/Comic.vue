<template>
  <v-layout align-start>
    <v-flex>
      <v-toolbar flat color="white">
        <v-toolbar-title>Comics</v-toolbar-title>
        <v-divider class="mx-2" inset vertical></v-divider>
        <v-spacer></v-spacer>
        <v-text-field
          class="text-xs-center"
          v-model="search"
          append-icon="search"
          label="Búsqueda"
          single-line
          hide-details
        ></v-text-field>
        <v-spacer></v-spacer>
        <v-dialog v-model="dialog" max-width="500px">
          <v-btn slot="activator" color="primary" dark class="mb-2">Nuevo</v-btn>
          <v-card>
            <v-card-title>
              <span class="headline">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>
              <v-container grid-list-md>
                <v-layout wrap>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="nombre" label="Nombre"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-date-picker v-model="fechaPublicacion" label = "Fecha_Publicacion"></v-date-picker>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-date-picker v-model="fechaRegistro" label = "Fecha_Registro"></v-date-picker>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="idioma" label="Idioma"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="genero" label="Genero"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="proveedor" label="Proveedor"></v-text-field>
                  </v-flex>
                </v-layout>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" flat @click.native="close">Cancelar</v-btn>
              <v-btn color="blue darken-1" flat @click.native="guardar">Guardar</v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
      <v-data-table :headers="headers" :items="comics" :search="search" class="elevation-1">
        <template slot="items" slot-scope="props">
          <td class="justify-center layout px-0">
            <v-icon small class="mr-2" @click="editItem(props.item)">edit</v-icon>
          
          </td>
          <td>{{ props.item.nombre }}</td>
          <td>{{ props.item.fechaPublicacion }}</td>
          <td>{{ props.item.fechaRegistro }}</td>
          <td>{{ props.item.idioma }}</td>
          <td>{{ props.item.genero }}</td>
          <td>{{ props.item.proveedor }}</td>
        </template>
        <template slot="no-data">
          <v-btn color="primary" @click="listar">Resetear</v-btn>
        </template>
      </v-data-table>
    </v-flex>
  </v-layout>
</template>
<script>
import axios from "axios";
export default {
  data() {
    return {
      comics: [],
      dialog: false,
      headers: [
        { text: "Opciones", value: "opciones", sortable: false },
        { text: "Nombre", value: "nombre", sortable: false },
        { text: "Fecha_Publicacion", value: "fechaPublicacion", sortable: false },
        { text: "Fecha_Registro", value: "fechaRegistro" },
        { text: "Idioma", value: "idioma" },
        { text: "Genero", value: "genero" },
        { text: "Proveedor", value: "proveedor"}
      ],
      search: "",
      editedIndex: -1,

      //Model
      id: "",
      nombre: "",
      fechaPublicacion: "",
      fechaRegistro: "",
      idioma: "",
      genero: "",
      proveedor: ""
    };
  },
  computed: {
    formTitle() {
      return this.editedIndex === -1 ? "Nuevo Comic" : "Actualizar Comic";
    }
  },

  watch: {
    dialog(val) {
      val || this.close();
    }
  },

  created() {
    this.listar();
  },
  methods: {
    listar() {
      let me = this;
      axios
        .get("api/comic")
        .then(function(response) {
          //console.log(response);
          me.comics = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },



    
    editItem(item) {
      this.id = item.id;
      this.nombre = item.nombre;
      this.fechaPublicacion = item.fechaPublicacion;
      this.fechaRegistro = item.fechaRegistro;
      this.idioma = item.idioma;
      this.genero = item.genero;
      this.proveedor = item.proveedor;

      this.editedIndex = 1;
      this.dialog = true;
    },

  

    close() {
      this.dialog = false;
    },
    limpiar() {
      this.id = "";
      this.nombre = "";
      this.fechaPublicacion = "";
      this.fechaRegistro = "";
      this.idioma = "";
      this.genero = "";
      this.proveedor = "";
    },
    guardar() {
      if (this.editedIndex > -1) {
        //Código para editar

        let me = this;
        axios 
          .put("api/comic", {
            id: me.id,
            nombre: me.nombre,
            fechaPublicacion: me.fechaPublicacion,
            fechaRegistro: me.fechaRegistro,
            idioma: me.idioma,
            genero: me.genero,
            proveedor: me.proveedor
          })
          .then(function(response) {
            me.close();
            me.listar();
            me.limpiar();
          })
          .catch(function(error) {
            console.log(error);
          });
      } else {
        //Código para guardar
        let me = this;
        axios
          .post("api/comic", {
            nombre: me.nombre,
            fechaPublicacion: me.fechaPublicacion,
            fechaRegistro: me.fechaRegistro,
            idioma: me.idioma,
            genero: me.genero,
            proveedor: me.proveedor
          })
          .then(function(response) {
            me.close();
            me.listar();
            me.limpiar();
          })
          .catch(function(error) {
            console.log(error);
          });
      }
    }
  }
};
</script>
