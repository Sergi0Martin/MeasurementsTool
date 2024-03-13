/** @type {import('tailwindcss').Config} */
export default {
	content: ['./src/**/*.{astro,html,js,jsx,md,mdx,svelte,ts,tsx,vue}'],
	theme: {
		extend: {},
		colors: { 'maize': { DEFAULT: '#ffe74c', 100: '#423900', 200: '#857300', 300: '#c7ac00', 400: '#ffde0a', 500: '#ffe74c', 600: '#ffec70', 700: '#fff194', 800: '#fff5b8', 900: '#fffadb' }, 'oxford_blue': { DEFAULT: '#041d3a', 100: '#01060b', 200: '#020c17', 300: '#021122', 400: '#03172e', 500: '#041d3a', 600: '#0a478d', 700: '#1071e1', 800: '#57a0f3', 900: '#abd0f9' }, 'gunmetal': { DEFAULT: '#203746', 100: '#060b0e', 200: '#0d161c', 300: '#13212a', 400: '#1a2c38', 500: '#203746', 600: '#3a637e', 700: '#578eb2', 800: '#8fb3cc', 900: '#c7d9e5' }, 'munsell': { DEFAULT: '#287f90', 100: '#08191d', 200: '#10333a', 300: '#184c56', 400: '#206573', 500: '#287f90', 600: '#36acc3', 700: '#65c2d5', 800: '#99d7e3', 900: '#ccebf1' } }
	},
	plugins: [],
}
