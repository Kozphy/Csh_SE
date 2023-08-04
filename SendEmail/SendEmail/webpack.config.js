const path = require('path');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = {
    //進入點 ，會根據entry指定的檔案內容去編譯、minify或bundle
    entry: {
        axios: './node_modules/axios/index.js', 
    },
    //JS檔產出設定- filename:產出的檔名 | path:產出的路徑
    output: {
        filename: 'axios.bundle.js',
        path: path.resolve(__dirname, './Scripts'),
    },
    module: {
        rules: [
            {
                test: /\.(scss|sass)$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    "css-loader",//後處裡css minify (順序2)
                    "sass-loader" //先處理sass 編譯 (順序1)
                ]
            }
        ]
    },
    plugins: [
        new MiniCssExtractPlugin({
            // 指定CSS輸出位置
            filename: "../Content/bundle.css"
        })
    ]
};