import {NextLink} from "../src/components/Link"

// SSG - Static Site Generation
// getStaticProps

export async function getStaticProps(context) { // roda apenas no build 
// a requisição é feita na build, para mudar o props precisa de uma nova build
// fazer a requisição aqui
// carrega o mais importante primeiro!
// em modo dev sempre roda
  return {
    props: {
      resposta: "returnDaRequisição"
    }, // will be passed to the page component as props

  }
}

//https://nextjs.org/docs/basic-features/data-fetching/get-server-side-props

// SSR - Server Side Rendering
// getServerSideProps
// a forma de usar é a mesma, mas ela consegue atualizar os dados quando houver mudanças
// roda a cada acesso


// getStaticProps roda na build X getServerSideProps roda a cada acesso


export default function Home({resposta}) {
  return (
    <div>
      <p> Home</p>
      <NextLink href="/teste">  ir para teste      </NextLink>
    </div>
  )
}
