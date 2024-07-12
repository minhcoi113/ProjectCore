const path = require('path');
const { defineConfig } = require('@vue/cli-service');
const CopyWebpackPlugin = require('copy-webpack-plugin');

module.exports = defineConfig({
  transpileDependencies: ['vuetify'],
  lintOnSave: false,
  publicPath: "/vuejs/template-rtl/",
  css: {
    extract: false,
  },
  chainWebpack: (config) => {
    config.resolve.alias
      .set('swiper$', 'swiper/js/swiper.js')
      .end();
  },

  configureWebpack: {
    module: {
      rules: [
        {
          test: /\.ico$/,
          loader: 'file-loader',
          options: {
            name: '[name].[ext]'
          }
        },
       
      ]
    },
    plugins: [
      new CopyWebpackPlugin({
        patterns: [
          {
            from: path.resolve(__dirname, 'src/assets/css'),
            to: path.resolve(__dirname, 'dist/css'),
          },
          {
            from: path.resolve(__dirname, 'src/assets/admin/css'),
            to: path.resolve(__dirname, 'dist/admin/css'),
          },
          {
            from: path.resolve(__dirname, 'src/assets/pharmacy/css'),
            to: path.resolve(__dirname, 'dist/pharmacy/css'),
          },
        ],
      }),
    ],
  },
});
