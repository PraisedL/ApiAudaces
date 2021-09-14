# ApiAudaces

Executando o código adicionar /graphql ou /playground na url.

No editor é possível fazer a chamada para o cálculo que retorna uma combinação possível como exemplo a seguir:

"mutation{
  calculate(input:{target:47, sequence:[5,20,2,1]})
}"

Se não possuir uma combinação possível retorna vazio.


--------------------------------------------------------------------------------


Para buscar os dados pode-se fazer queries como: 

"query{
  calls{
    nodes{
      target
      sequence
      date,
      foundSequence
    }
  }
}"

Ou ainda é possível adicionar um where na query assim pode-se buscar dados entre datas como:

"query{
  calls(where:{
    date_gt:"2021-09-12"
    date_lt:"2021-09-14"
  }){
    nodes{
      target
      sequence
      date,
      foundSequence
    }
  }
}"


--------------------------------------------------------------------------------


Ao baixar o código também terá um sqlite com alguns dados que já foram testados. 

Está aplicação também está hospedada no heroku e disponível em http://teste-audaces-api.herokuapp.com/graphql/
