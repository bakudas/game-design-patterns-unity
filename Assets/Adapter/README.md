# Adapter Pattern

## Propósito
Estrutural

## Escopo
Classe ou Objeto

## Definição do Padrão
Há dois padrões Adapter dentro da categoria de Design Patterns com o propósito Estrutural, sendo o adaptador de classe e de objetos.
A diferença é sutil. O Adapter de Classe usa herança e só pode envolver uma classa; ele não pode envolver uma interface, pos, por definição, deve derivar de alguma classe base.
Por outro lado, o de objetos usa composição e pode envolver classes ou interfaces, ou ambos, pois contém, como um membro encapsulado particular, a instância de objeto de classe ou interface.
Ou seja, o Adpater atua como um intermediador, tal como um adaptador é um intermediário entre tomadas de energia de padrões de pinos diferentes.