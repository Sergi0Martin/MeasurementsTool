import { defineConfig } from 'astro/config';

import tailwind from "@astrojs/tailwind";

// https://astro.build/config
export default defineConfig({
  site: 'https://Sergi0Martin.github.io',
  base: '/MeasurementsTool',
  integrations: [tailwind()]
});