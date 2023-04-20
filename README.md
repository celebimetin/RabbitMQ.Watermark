# RabbitMQ.Watermark

Resimlere watermark ekleme işlemini RabbitMQ aracalığı backgroundService'de gerçekleştiriyorum.

Web uygulamamızda resimler kaydedilirken, aynı zamanda resimlere yazı eklenmektedir. Bu işlem uzun sürdüğünden dolayı iyi bir kullanıcı deneyimi sunmamaktadır. Bu işlemi BackgroundService üzerinden rabbitMQ ile haberleşerek gerçekleştiriyoruz. Bu sayede ; resim ekleyen kullanıcılar daha az süre işlemin bitmesini bekleyecekler.
