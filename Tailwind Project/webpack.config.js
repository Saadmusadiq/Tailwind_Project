import path from 'path';
import { fileURLToPath } from 'url';

// Convert __dirname and __filename for ES module
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

export default {
    entry: './wwwroot/js/index.js',  // Entry point of your JavaScript file
    output: {
        filename: 'bundle.js',  // Name of the output file
        path: path.resolve(__dirname, 'wwwroot/dist'),  // Output directory
    },
    module: {
        rules: [
            {
                test: /\.css$/i,
                use: ['style-loader', 'css-loader'],  // Loaders for CSS files
            },
        ],
    },
    mode: 'development',  // Set to 'production' for minified output
};
