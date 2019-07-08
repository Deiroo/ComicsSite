import Vue from 'vue'
import Vuetify from 'vuetify/lib'
import 'vuetify/src/stylus/app.styl'

Vue.use(Vuetify, {
  theme: {
    primary: '#00BCD4',
    secondary: '#FB8C00',
    accent: '#00BCD4',
    error: '#FF5252',
    info: '#2196F3',
    success: '#4CAF50',
    warning: '#00BCD4'
  },
  options: {
    customProperties: true
  },
  iconfont: 'md',
})
