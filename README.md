# S.O.L.I.D.

### S
- Single Responsability Principle ( Principio da Responsabilidade Única ), Afirma que uma classe deve ter apenas uma razão para mudar, ou seja, deve ter apenas uma  responsabilidade. Isso significa que uma classe deve ser especializada em fazer uma coisa e fazer isso bem

### O
- Open/Closed Principle ( Principio Aberto e Fechado ), As entidades de software(classes, modulos, funçoes, etc) devem ser abertas para extençoes, mas fechadas para modificaçoes. Isso significa que o comportamento de uma classe deve ser estendido sem alterar seu código fonte. Isso é geralmente alcançado usando herança, interfaces, polimorfismo e padrões de projeto como Strategy e Template Method

### L
- Liskov Substitution Principle ( Principio de Substituição de Liskov ), Este Principio Afirma que objetos de um supertipo devem ser substituiveis por objetos de subtipo sem afetar a integridade so programa. Isso significa que uma subclasse deve estender, não substituir, o comportamento de sua classe base. Ao seguir este princípio, é possível escrever código mais modular e flexível, promovendo a reutilização de código.

### I
- Interface Segregation Principle ( Principio de segregação de interfaces ), Afirma que muitas interfaces especificas são melhores que uma interface unica. Isso significa que uma interface deve ter um conjunto coeso e especifico de métodos relacionados,, ao inves de ter muitos metodos relacionados

### D
- Dependency Inversion Principle ( Principio da Inversão de Dependencia ), Afirma que os modulos de alto nivel não devem depender de modulos de baixo nivel. O principio incentiva a dependencia de abstraçoes em vez de implementaçoes concretas. um exemplo ilustra melhor

```csharp
public class NotificationService
{
    public void SendEmail(string to, string message)
    {
        // Lógica para enviar e-mail
    }

    public void SendSMS(string to, string message)
    {
        // Lógica para enviar SMS
    }

    public void SendPushNotification(string to, string message)
    {
        // Lógica para enviar notificação push
    }
}

// Exemplo de uso
var notificationService = new NotificationService();
notificationService.SendEmail("user@example.com", "Hello!");
```