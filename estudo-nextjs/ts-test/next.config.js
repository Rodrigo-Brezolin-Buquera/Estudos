/** @type {import('next').NextConfig} */
const nextConfig = {
  reactStrictMode: true,
  images: {
    domains: ['rickandmortyapi.com'],
  },
  // images: {
  //   remotePatterns: [
  //     {
  //       protocol: 'https',
  //       hostname: ' "rickandmortyapi.com",',
  //       port: '',
  //       pathname: '/api/characters/**',
  //     },
  //   ],
  // },
}

module.exports = nextConfig
