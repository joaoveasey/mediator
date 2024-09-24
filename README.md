# Mediator Pattern

## 📖 Definição
- O Mediator é um padrão de design que define um objeto que encapsula como um conjunto de objetos interage. Ele promove um acoplamento fraco. O mediator facilita a comunicação entre um grupo de objetos sem que haja um acoplamento direto entre eles, utilizando um objeto mediador para gerenciar essas interações.

### 🚫 Sem Mediator
- Em sistemas sem o padrão mediator, há um forte acoplamento entre os objetos A, B, C e D, como demonstrado na imagem abaixo.
![image](https://github.com/user-attachments/assets/931107f6-0ffb-4068-b14b-d101fd952c0f)


### ✅ Com Mediator
- Ao utilizar o mediator, cada objeto envia sua mensagem para o mediador, que então roteia essa mensagem para o objeto de destino. Assim, cada objeto trabalha de forma independente, sem criar acoplamento entre si.
![image](https://github.com/user-attachments/assets/40ede270-571d-4b30-a1eb-c2262982f1d9)

### 🛠️ Quando Usar?
- Quando as mudanças no estado de um objeto afetam outros objetos.
- Quando o grande número de interconexões de objetos torna o sistema complexo e difícil de entender.
- Quando há necessidade de realizar manutenção em um objeto específico sem impactar os outros.
- Quando existem muitos relacionamentos entre objetos e é necessário um ponto comum de controle.

### 👍 Vantagens
- Desacoplamento: Os objetos não precisam se conhecer diretamente para se comunicarem, passando suas informações ao mediador, que repassa para o receptor.
- Fluxo de comunicação centralizado: Toda a comunicação é centralizada no mediador, facilitando o controle e a manutenção.
- Facilidade de mudanças: Como os objetos são independentes, alterações podem ser aplicadas a eles sem afetar os demais.

### 👎 Desvantagens
- Possível gargalo de desempenho: Dependendo da quantidade de objetos, o mediador pode se tornar uma fonte de gargalo e, em caso de falha, comprometer todo o sistema.
- Complexidade crescente: Na prática, mediadores podem se tornar cada vez mais complexos à medida que o sistema cresce.


### 🔗 Referências
- 🎥 Padrão Mediator - Macoratti (https://www.youtube.com/watch?v=YM9lbsq4H5s&list=WL&index=3)
