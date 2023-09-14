import GlobalStyle from '../src/theme/GlobalStyle'
import '../styles/globals.css'
import Head from "next/head"

function MyApp({ Component, pageProps }) {
  return (
    <>
    <Head>
      // baixar as fontes globais e por o links aqui
    </Head>
      <GlobalStyle />
      <Component {...pageProps} />
    </>
  )


}

export default MyApp
