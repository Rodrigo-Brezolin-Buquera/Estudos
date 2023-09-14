teste de queries 

// tudo dentro de {
query(parametros) {
    campos que quer retornar
}


}

{
  country(code: "BR") {
    code
    name
    phone
    capital
    currency
    continent {
      code
      name
      countries {
        name
        capital
      }
    }
  }
}

{
  languages {
    code
    name
    native
    rtl
  }
}