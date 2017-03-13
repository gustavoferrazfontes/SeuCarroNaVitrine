# Cast Modelo de domínio e ORM - Como lidar com a complexidade acidental no seu domínio.

Sample utilizada para apresentar conceitos DDD, seus desafios de persistência utilizando dois dos principais ORM do mercado: NHibernate e Entity Framework e também com o micro ORM Dapper

Nesta Sample, Criamos um modelo rico que contem:

- Enum vs Enumeration Class
- Identidade, como um Objeto de valor para uso de Ids
- Objeto de Valor
  - Imutabilidade
  - Thread Safe
  - Auto-Validação
  - Evitando Primitive Obsession
- Entidade
- Agregação
- Modelagem Relacional
  - Repositorio de persistência Com NHibernate
  - Repositorio de persistência Com Entity Framework
  - Repositorio de persistência Com Dapper

