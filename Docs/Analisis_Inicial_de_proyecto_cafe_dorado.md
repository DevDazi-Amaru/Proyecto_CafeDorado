# ENUNCIADO

La cooperativa **“Café Dorado”** *gestiona* la producción de café de más de 100 pequeños productores. Actualmente, el *registro* de kilos entregados, pagos y calidad del grano se lleva en hojas físicas, lo que ha causado reclamos por errores en los pagos.

Los socios de la cooperativa lo contratan como ingeniero de sistemas para el desarrollo del sistema que les resolverá esta situación problémica, donde le indican que el sistema urge para que les sea entregados en Diciembre últimos días del mes y que tienen buen presupuesto, le hace referencia de las necesidades que debe llevar y le pone en contexto de la problemática  
  

- Registro de productores, lotes de café y kilos entregados.
- Cálculo automático de pagos según calidad del grano.
- Generación de reportes de entregas por productor.
- Historial digital de pagos y transacciones.
- Funcionalidad para exportar datos a Excel/PDF.

# Primeras suposiciones
Aparentemente la empresa **Café Dorado** Es una popular distribuidora de café la cual esta encargada de controlar, contabilizar y organizar la producción y ganancia de todos sus productores afiliados. 
Las operaciones de la empresa inician con la supervisión de todos sus productores, Analizando cuanto su cantidad y calidad de su producción, para luego, en días de cosecha, comparar la calidad del producto, cual es la cantidad entregada y cual es el precio que se le da a ese productor por el lote entregado.

# Posibles tablas a crear
1. Empleados 
2. Productores 
3. Lotes de café recibidos 
4. Cafés existentes en la empresa
5. Facturas realizadas 

## Justificación
1. **Empleados:** Son los encargados de iniciar sesión, y serán referenciados en las operaciones realizadas (Facturas realizadas, lotes recibidos)
2. **Productores:** Entidades que venden y dejan a la orden su mercancía
3. **Lotes de café Recibidos:** Conjunto de cafés, que contiene primordialmente, que tipo de café se obtuvo, quien lo recibió, quien lo vendió, la calidad del café, su cantidad y su precio
4. **Cafés existentes en la empresa:** Se trata de la contabilización de productos (cafés) con sus propiedades y en que lugar se almacenan y su lote de procedencia
5. **Facturas realizadas**: Registro de todos los pagos hechos a los productores
# Análisis previo
¿Qué requiere la empresa **Café Dorado** para solucionar su problema?
*La empresa "Café Dorado" requiere de un sistema que pueda gestionar las operaciones de contabilización de mercancía y financiera  con sus productores*

¿Qué preciso de la empresa **Café Dorado** para llevar a cabo su solución?
*Para tener un buen resultado primeramente necesito colaboración de la empresa con información de las propiedades y/o características de como registran sus proveedores, productos, lotes y pagos, así como contexto de actividades y/o procedimientos que realiza la empresa en el entorno y/o situación del problema*

¿De qué forma llevare a cabo el resultado de la solución requerida por la empresa?
*Con un tiempo urgente de 2 meses la precisión es fundamental, por lo que preciso un buen tiempo para el análisis y recolección de información. Necesito que el contratista de mis servicios y/o el gerente general acceda a una reunión/entrevista conmigo, para responder dudas acerca del producto final y proceder con el análisis y organización de propiedades de datos y así poder proceder con al menos el primer prototipo de la solución*

# Preguntas para primera entrevista con la entidad empresa

## Simulación

>Buenas tardes, Sres. Café Dorado.
>Muchas gracias por contactarme, he leído su correo y estaré encantado de encontrar y crear la solución a su problema.
>Durante este tiempo me he tomado la tarea de analizar su correo para ponerme en contexto de que es lo que llegaré a realizar, pero para elaborar un excelente producto final, pido su entera colaboración con su disposición para responder algunas dudas que tengo con el manejo de operaciones, funcionalidades y expectativas de el resultado final
>La primera y fundamental pregunta es acerca de la funcionalidad **¿Qué es en lo que se enfoca su empresa?, ¿Qué realizan junto a los productores? y/o ¿Qué flujo de trabajo es el que hacen?** todas las preguntas representan un mismo contexto, pero la ultima pregunta es fundamental para tener una pequeña noción de como quieren que la solución funcione.
>En mi previo análisis he realizado una pequeña suposición de las funcionalidades de la empresa y me gustaría que me confirmen, corrijan y afirmen las funcionalidades reales.
>"Aparentemente la empresa **Café Dorado** Es una popular distribuidora de café la cual esta encargada de controlar, contabilizar y organizar la producción y ganancia de todos sus productores afiliados. 
>Las operaciones de la empresa inician con la supervisión de todos sus productores, Analizando cuanto su cantidad y calidad de su producción, para luego, en días de cosecha, comparar la calidad del producto, cual es la cantidad entregada y cual es el precio que se le da a ese productor por el lote entregado."
>Por otro lado, A como mencione, me gustaría que respondiera a las siguientes preguntas de carácter especifico

## Preguntas
1. ¿De qué forma registra a sus empleados? A parte del ID, Nombre y contraseña
2. ¿A qué se refiere con la **gestión** de productos? ¿De qué manera se involucra con sus productores para gestionar sus producciones?
3. ¿Qué tipos de cafés son entregados por los productores? Menciónelos todos
4. ¿Cuáles son las calidades con las que se clasifican los cafés?
5. ¿La calidad de los cafés se mide en porcentaje o de forma cualitativa?
6. ¿Únicamente le gestiona a pequeños productores?
7. ¿Qué información registra de cada uno de los productores? Detálleme la función de cada propiedad
8. ¿Ya cuenta con una forma de contactar a sus productores? ¿O no precisa de esta función en su programa?
9. ¿De qué manera y con qué propiedades registra los cafés?
10. ¿De qué manera y con qué propiedades registra los lotes de cafés recibidos?
11. ¿De qué manera y con qué propiedades registra la facturación del lote recibido?
12. ¿Únicamente utiliza el kilogramo como medida de pesaje?
13. ¿En que moneda realiza las facturaciones? 
14. ¿Desea generar una factura en formato pdf a la hora de realizar la facturación?
15. ¿Qué tipo de reclamos recibía? ¿Qué tipo de errores tenia con ese sistema que le afectaba en los pagos?
16. ¿Cuál es el proceso de cálculo de los pagos? ¿tiene una tasa por calidad del producto que se multiplica por el tipo de café base y luego se multiplica por la cantidad de café recibido?
17. ¿En la facturación de los pagos cuenta con alguna actividad extra? ¿Tal cómo un bono por total de cantidad o un bono por café de calidad excelente?
18. ¿El reporte de entrega va incluido o separado de la factura? ¿Igualmente lo requiere en formato pdf u otro formato?
19. En caso que considere que algo importante de la funcionalidad de la empresa se me paso por alto preguntar ¿Podría reportarme de dicha funcionalidad que le gustaría incluir?
20. Ahora hablando de diseños ¿Podría colaborarme con todo el branding e identidad de su empresa? Esto para conocer sus colores mas representativos y por supuesto luego podría pasarme el logo oficial de la empresa
21. En cuanto al diseño, también me gustaría que me especificara como realmente le gustaría la apariencia del programa ¿Desea qué se vea rustico, o de que forma?

> Creo que esas son todas las dudas que se me generaron hasta el momento, quizás con su respuesta surjan mas de estas, y por supuesto, si alguna respuesta a alguna pregunta necesita otra reunión siempre estoy disponible

# Primera Respuesta de la entidad empresa (Simulada con Inteligencia artificial)

Buenas tardes, estimado Ingeniero.

Es un verdadero gusto saludarle en nombre de la Junta Directiva de la **Cooperativa Café Dorado**. Nos alegra mucho ver el nivel de detalle, profesionalismo y compromiso con el que ha tomado nuestro caso desde este primer contacto. Como le comentamos, contamos con el presupuesto necesario y toda la disposición de colaborar con usted porque necesitamos tener este sistema operando a finales de diciembre sin falta.

### Sobre su análisis previo y el flujo de trabajo general

Su suposición inicial está muy bien encaminada, pero me gustaría hacerle una **precisión importante sobre nuestro flujo real de trabajo** para que el sistema se adapte exactamente a lo que hacemos:

Nosotros somos una **cooperativa de [^1]acopio, procesamiento y comercialización**, no solo una distribuidora. No vamos a las fincas todos los días a supervisar el cultivo (cada productor cuida su parcela), sino que **nuestra operación crítica en el sistema inicia en nuestro Centro de Acopio (Beneficio)** durante los días de cosecha.

El flujo exacto de trabajo es el siguiente:

1. **Recepción y Pesaje:** El productor afiliado llega a nuestro centro de acopio con su cosecha en sacos. Nuestro personal recibe el lote y lo pesa en báscula.
    
2. **Análisis de Calidad (Laboratorio):** Se toma una muestra del lote entregado para medir su humedad y porcentaje de defectos, asignándole una categoría de calidad.
    
3. **Registro del Lote:** Se guarda la boleta de entrada asociando al productor, el tipo de café, los kilos netos y la calidad obtenida.
    
4. **Liquidación y Pago (Facturación):** Con base en los kilos netos, la variedad del café y su calidad, el sistema calcula automáticamente cuánto se le debe pagar al productor, aplica bonos o retenciones, registra la transacción en el historial y emite el comprobante de pago.
    

### Respuestas a sus preguntas específicas

**1. ¿De qué forma registra a sus empleados? Aparte del ID, Nombre y contraseña.**

Para tener control interno y saber quién registró cada pesaje o quién autorizó un pago, necesitamos registrar de cada empleado:
- **ID de Empleado** (Código interno o autoincremental).
    
- **Número de Cédula** (Identificación legal).
    
- **Nombre Completo**.
    
- **Cargo o Rol en el sistema:** Manejamos principalmente 3 roles: _Administrador_ (acceso total), _Recepcionista de Acopio / Pesador_ (registra productores y entradas de lotes) y _Cajero / Liquidador_ (procesa pagos y reportes).
    
- **Teléfono y Correo Electrónico**.
    
- **Nombre de Usuario y Contraseña**.
    
- **Estado** (Activo / Inactivo).
    

**2. ¿A qué se refiere con la gestión de productos? ¿De qué manera se involucra con sus productores para gestionar sus producciones?**

Cuando hablamos de "gestionar la producción de más de 100 pequeños productores", nos referimos al **control del acopio y trazabilidad de las entregas** que ellos traen a la cooperativa. Nos involucramos llevando el control exacto de cuánto café produce y entrega cada socio por temporada, qué calidad está sacando su finca y cuánto dinero le ha generado su cosecha dentro de la cooperativa.

**3. ¿Qué tipos de cafés son entregados por los productores? Menciónelos todos.**

Nuestros productores cultivan café de la especie _Arábica_ y nos entregan **4 variedades principales** (todas se reciben en estado de _Café Pergamino Seco_):

1. **Caturra** (El más común y balanceado).  
    
2. **Borbón** (De excelente taza, muy cotizado).
    
3. **Catimor** (De alto rendimiento y resistente).
    
4. **Maragogipe** (Grano gigante especial, de mayor valor base).
    

**4. ¿Cuáles son las calidades con las que se clasifican los cafés?**

Clasificamos cada lote recibido en **4 niveles de calidad**:

- **Calidad Oro (Exportación Especial / Tipo A):** Grano impecable, de estricta altura y humedad óptima.
    
- **Calidad Primera (Estándar Exportación / Tipo B):** Grano muy bueno con defectos mínimos permitidos.
    
- **Calidad Segunda (Comercial / Tipo C):** Grano con defectos moderados o humedad ligeramente fuera de rango.
    
- **Calidad Tercera (Consumo Local / Tipo D):** Grano quebrado, manchado o con exceso de humedad/impurezas.
    

**5. ¿La calidad de los cafés se mide en porcentaje o de forma cualitativa?**

¡Excelente pregunta! En realidad, **usamos ambas conectadas**: nuestro catador ingresa valores numéricos en porcentaje y el sistema debe determinar la calidad cualitativa automáticamente:

- Se mide el **Porcentaje de Humedad (%)** y el **Porcentaje de Defectos/Impurezas (%)** de la muestra:
    
    - **Calidad Oro:** Humedad entre `10% y 12%` y Defectos menores o iguales al `3%`.
        
    - **Calidad Primera:** Humedad entre `10% y 13%` y Defectos entre `3.1% y 7%`.
        
    - **Calidad Segunda:** Humedad hasta `14.5%` y Defectos entre `7.1% y 12%`.
        
    - **Calidad Tercera:** Humedad mayor a `14.5%` o Defectos mayores al `12%`.
        

**6. ¿Únicamente le gestiona a pequeños productores?**

El 90% de nuestro padrón son pequeños productores (más de 100 socios), pero también contamos con un grupo menor de **medianos productores**. En el sistema nos gustaría clasificarlos por **Categoría de Productor** (_Pequeño Productor_, _Mediano Productor_, _Socio Fundador_), ya que esto nos sirve para reportes estadísticos.

**7. ¿Qué información registra de cada uno de los productores? Detálleme la función de cada propiedad.**

- **Código / ID de Productor:** Identificador único del socio dentro de la cooperativa.
    
- **Cédula de Identidad:** Requisito legal indispensable para emitir pagos y evitar duplicados.
    
- **Nombre Completo:** Identificación personal del productor.
    
- **Nombre de la Finca / Parcela:** Para trazabilidad del origen del lote de café.
    
- **Comunidad / Municipio:** Ubicación geográfica de la finca para saber de qué zona proviene el mejor grano.
    
- **Altitud de la Finca (msnm):** Metros sobre el nivel del mar (dato técnico de referencia).
    
- **Teléfono de Contacto:** Para avisarle cuando su pago o liquidación esté lista.
    
- **Categoría de Productor:** (Pequeño, Mediano, Fundador) para segmentación.
    
- **Estado del Socio:** (Activo / Inactivo).
    

**8. ¿Ya cuenta con una forma de contactar a sus productores? ¿O no precisa de esta función en su programa?**

Actualmente nos comunicamos con ellos por llamadas telefónicas o WhatsApp de forma externa. No necesitamos que el programa envíe mensajes por sí solo, pero **sí necesitamos que en su perfil estén visibles su teléfono y correo electrónico** para contactarlos rápidamente o enviarles sus comprobantes en PDF.

**9. ¿De qué manera y con qué propiedades registra los cafés?**

Manejamos un catálogo base de las variedades de café que recibimos. Sus propiedades son:

- **ID de Variedad / Tipo de Café**.
    
- **Nombre de la Variedad** (Caturra, Borbón, Catimor, Maragogipe).
    
- **Precio Base por Kilo** (El valor base de referencia en el mercado antes de evaluar la calidad).
    
- **Descripción / Características**.
    

**10. ¿De qué manera y con qué propiedades registra los lotes de cafés recibidos?**

Cada vez que un productor entrega café en báscula, se genera un registro de **Lote / Entrega** con:

- **Código / Número de Lote** (Identificador único de la entrega).
    
- **Fecha y Hora de Recepción**.
    
- **Productor Asociado** (ID del productor que entrega).
    
- **Variedad de Café** (Caturra, Borbón, etc.).
    
- **Cantidad de Sacos** (Número de sacos físicos entregados).
    
- **Kilos Brutos** (Peso total en la báscula incluyendo los sacos).
    
- **Tara / Descuento de Sacos (kg)** (Se descuenta aproximadamente `0.5 kg` por cada saco vacío, o el peso de impurezas físicas).
    
- **Kilos Netos** (`Kilos Brutos - Tara`, que son los kilos reales de café a pagar).
    
- **Porcentaje de Humedad (%)** y **Porcentaje de Defectos (%)**.
    
- **Calidad Asignada** (Oro, Primera, Segunda, Tercera).
    
- **Empleado Receptor** (Quién registró la entrada).
    
- **Estado del Lote** (_Pendiente de Pago_ / _Liquidado_).
    

**11. ¿De qué manera y con qué propiedades registra la facturación del lote recibido?**

En el gremio cafetalero a esta factura le llamamos **"Liquidación de Café"** (o Comprobante de Pago). Sus propiedades son:

- **Número de Liquidación / ID de Pago**.
    
- **Fecha de Emisión del Pago**.
    
- **Productor Beneficiario**.
    
- **Lote Liquidado:** El lote específico que se está pagando en esa transacción (para mantener la contabilidad simple y transparente con el productor, generaremos un recibo único por cada lote entregado).
    
- **Total de Kilos Netos a Pagar**.
    
- **Precio Base por Kilo** y **Precio Ajustado por Calidad**.
    
- **Subtotal por Café**.
    
- **Bonificaciones Aplicadas** (Monto extra en dinero si cumplió metas de volumen o excelencia).
    
- **Retención Cooperativa** (Deducción del **2%** que queda como aporte de mantenimiento para la cooperativa).
    
- **Monto Total Neto a Pagar**.  
    
- **Método de Pago** (Efectivo, Cheque o Transferencia Bancaria). 
    

**12. ¿Únicamente utiliza el kilogramo como medida de pesaje?**

**Sí, el Kilogramo (kg) es nuestra unidad oficial y obligatoria** para todos los registros y cálculos en la base de datos (así evitamos los enredos que teníamos antes en las hojas de papel). Como detalle opcional, si usted desea poner en pantalla una etiqueta informativa que muestre a cuántos quintales equivale (1 quintal = 46 kg), sería un bonito detalle visual, pero todos los cálculos y registros deben ser en **Kilogramos**.

**13. ¿En qué moneda realiza las facturaciones?**

Todas las liquidaciones y pagos a nuestros productores se realizan en moneda nacional: **Córdobas (C$)**.

**14. ¿Desea generar una factura en formato PDF a la hora de realizar la facturación?**

**¡Sí, por supuesto!** Al momento de registrar un pago, necesitamos poder exportar o generar el comprobante de liquidación en **formato PDF** para poder imprimirlo, sellarlo y entregárselo al productor (o mandárselo digitalmente).

  

**15. ¿Qué tipo de reclamos recibía? ¿Qué tipo de errores tenía con ese sistema que le afectaba en los pagos?**

Con las hojas físicas teníamos cuatro problemas gravísimos:

1. **Errores aritméticos manuales:** El encargado hacía las cuentas con calculadora de mano y aplicaba mal los porcentajes de calidad o se equivocaba al multiplicar los kilos.
    
2. **Extravío de boletas de entrega:** Un productor entregaba 3 lotes en distintas fechas del mes y, al llegar el día de pago, se había traspapelado una hoja y solo se le querían pagar 2 lotes.
    
3. **Caligrafía ilegible y tachones:** Números confusos en el papel (confundir un `1` con un `7`, o un `3` con un `8` en los kilos pesajes) que causaban pérdidas de miles de córdobas.
    
4. **Doble cobro o pagos sin respaldo:** No sabíamos con certeza qué lotes ya estaban pagados y cuáles seguían pendientes.
    

**16. ¿Cuál es el proceso de cálculo de los pagos? ¿Tiene una tasa por calidad del producto que se multiplica por el tipo de café base y luego se multiplica por la cantidad de café recibido?**

¡Exactamente así como lo acaba de describir! La fórmula sigue este orden estricto:

1. Tomamos el **Precio Base por Kilo** según la variedad de café:
    
    - _Catimor:_ `C$ 100.00 / kg`
        
    - _Caturra:_ `C$ 115.00 / kg`
        
    - _Borbón:_ `C$ 125.00 / kg`
        
    - _Maragogipe:_ `C$ 145.00 / kg`
		

2. Multiplicamos ese precio base por el **Factor de Calidad**:
    
    - **Calidad Oro (A):** Se paga un **+20%** sobre el precio base (`Precio Base * 1.20`).
        
    - **Calidad Primera (B):** Se paga el **100%** del precio base (`Precio Base * 1.00`).
        
    - **Calidad Segunda (C):** Sufre un castigo del **-15%** (`Precio Base * 0.85`).
        
    - **Calidad Tercera (D):** Sufre un castigo del **-30%** (`Precio Base * 0.70`).
        

3. Ese **Precio Ajustado por Kilo** se multiplica por los **Kilos Netos** del lote:
    $$\text{Subtotal} = \text{Kilos Netos} \times \text{Precio Ajustado por Kilo}$$
    

**17. ¿En la facturación de los pagos cuenta con alguna actividad extra? ¿Tal como un bono por total de cantidad o un bono por café de calidad excelente?**

¡Sí! Manejamos dos incentivos y una retención fija que el sistema debe calcular automáticamente:

- **Bono por Volumen de Entrega:** Si la entrega (o el total de kilos a liquidar) supera los **500 kg netos**, se le otorga un **bono del 5% adicional** sobre el Subtotal.
    
- **Bono por Excelencia (Grano de Oro):** Si el lote calificó como **Calidad Oro** y además tuvo **0% de defectos**, se le premia con **C$ 3.00 adicionales por cada kilo neto**.
    
- **Retención de Aporte Cooperativo:** A todo subtotal se le descuenta un **2%** fijo por concepto de papelería y mantenimiento de la cooperativa.
    
    - _Fórmula Final:_ $\text{Total a Pagar} = \text{Subtotal} + \text{Bonos} - \text{Retención (2\%)}$.
        

**18. ¿El reporte de entrega va incluido o separado de la factura? ¿Igualmente lo requiere en formato PDF u otro formato?**

Son dos momentos distintos:

- **Reporte de Entregas por Productor:** Es un listado histórico donde podemos consultar todos los lotes que un productor ha entregado en la temporada (kilos, fechas, calidades y si ya fueron pagados o no).
    
- **Historial / Comprobante de Pagos (Liquidación):** Es el registro financiero de los pagos efectuados.
    
    Queremos que tanto los reportes de entregas como el historial de pagos se puedan **exportar a Excel y a PDF**, tal como le indicamos en los requerimientos iniciales, para que contabilidad pueda trabajar las tablas en Excel y la gerencia pueda archivar los PDF.
    

**19. En caso que considere que algo importante de la funcionalidad de la empresa se me pasó por alto preguntar, ¿podría reportarme de dicha funcionalidad que le gustaría incluir?**

Sí, hay dos detalles operativos que nos ayudarían muchísimo:

1. **Pesaje de sacos por lote:** A veces un productor trae varios sacos físicos en un solo viaje. Sería excelente que el sistema registre esos sacos como un único 'Lote' total en la recepción, sumando los kilos ahí mismo, para que al momento de facturar, el cajero solo tenga que liquidar ese lote de forma directa en una sola boleta.".
    
2. **Validaciones estrictas de entrada:** Para no repetir los errores del papel, necesitamos que el sistema no permita guardar lotes con kilos en cero o negativos, ni porcentajes de humedad imposibles (por ejemplo, menores a 0% o mayores a 50%), ni dejar campos obligatorios vacíos.
    

**20. Ahora hablando de diseños, ¿podría colaborarme con todo el branding e identidad de su empresa? Esto para conocer sus colores más representativos y por supuesto luego podría pasarme el logo oficial de la empresa.**

Con mucho gusto. Nuestra identidad visual gira en torno a la elegancia del grano de café y el brillo del oro:

- **Color Primario (Café Espresso / Tostado Oscuro):** `#3E2723` o `#4E342E` (para menús laterales, encabezados y barras superiores).
    
- **Color de Acento (Dorado Cosecha / Ámbar):** `#D4AF37` o `#C99E32` (para botones principales, iconos destacados y bordes activos).
    
- **Color de Fondo (Crema Pergamino / Hueso):** `#F7F3EE` o `#EFEBE9` (para el fondo de las áreas de trabajo, dando una lectura limpia y descansada).
    
- **Color de Acción Positiva (Verde Cafetal):** `#2E7D32` (para botones de confirmación, guardado y estados de "Pagado").
    
    _(El logotipo oficial lleva un grano de café dorado en el centro rodeado por dos ramas de cafeto sobre un fondo café oscuro; puede usar un icono representativo de una taza o grano dorado mientras le enviamos el archivo vectorial)._
    

**21. En cuanto al diseño, también me gustaría que me especificara cómo realmente le gustaría la apariencia del programa. ¿Desea que se vea rústico, o de qué forma?**

Queremos evitar que se vea antiguo o recargado. Buscamos un estilo **Moderno, Corporativo y Limpio con calidez cafetalera** (un diseño plano o _Flat UI_ elegante). Que tenga un menú lateral bien organizado para navegar entre formularios, tarjetas o paneles bien alineados para separar los datos del productor de los cálculos de pago, tipografía moderna y clara (como _Segoe UI_ o _Century Gothic_), y tablas de datos (_DataGridViews_) estilizadas con encabezados en tono café y filas alternadas en tono crema.

Espero que estas respuestas le den toda la claridad que necesita para estructurar la base de datos y los formularios del primer avance, Ingeniero. Quedo a su entera disposición por si surge alguna otra duda técnica o sobre las reglas del negocio. ¡Mucho éxito con el diseño!



# Dudas surgidas

1. Aproximadamente, ¿con cuántos empleados cuenta la empresa? y/o ¿Cuál es el limite de empleados?
2. ¿El programa va a estar en una única computadora o van a haber varias computadoras? Es decir, ¿Se podrá llegar a dar el caso que dos trabajadores realicen una recepción de lotes al mismo tiempo?
3. ¿Hay algún tipo de id en especifico que le gustaría seguir? algo como las dos primeras 2 letras del puesto y un numero incremental?
4. En la diferenciación de roles ¿El Recepcionista puede ver (obviamente sin tener el permiso de realizar) lo que el cajero hace? o ¿Prefiere que se oculte el acceso total de las funciones y formularios de cada rol? prácticamente irían a lo que van según su rol.
5. ¿Hay alguna validación de correo? como un correo propio de la cooperativa
6. ¿Cómo le gustaría generar el usuario del empleado?
7. ¿Qué validaciones deberá tener la contraseña del empleado?
8. ¿Cuántos intentos deberá tener el empleado antes de entrar al sistema y que pasara si usa todos los intentos?
9. ¿Cómo le gustaría registrar los siguientes IDs? como el de los productores, café, lotes y recibos 
10. ¿El precio base por kilo esta estandarizado a como me los dijo en la pregunta 16. o cambian con el tiempo?
11. le parecería discutir luego en que estructura del contenido desea crear los comprobantes/reportes y liquidaciones? por ejemplo, un encabezado y la estructura del texto

# Segunda Respuesta de la entidad empresa (Simulada con Inteligencia artificial)
Buenas tardes, estimado Ingeniero.

Qué gusto recibir sus consultas. Se nota que está cuidando cada detalle técnico y de seguridad antes de tirar la primera línea de código; eso nos da muchísima tranquilidad como clientes.

Aquí tiene las respuestas puntuales de nuestra Junta Directiva a cada una de sus dudas:

**1. Aproximadamente, ¿con cuántos empleados cuenta la empresa? y/o ¿cuál es el límite de empleados?** Aunque gestionamos a más de 100 productores, nuestro personal administrativo y operativo en el centro de acopio es pequeño. Actualmente somos **12 empleados en planilla**, de los cuales solo **6 a 8 personas** usarán el sistema (1 Administrador general, 2 Cajeros liquidadores y 4 Recepcionistas de báscula/laboratorio). Incluso en temporada alta, el límite máximo de empleados usando el sistema nunca superará los **25 o 30 usuarios**.

**2. ¿El programa va a estar en una única computadora o van a haber varias computadoras? ¿Se podrá dar el caso de dos recepciones al mismo tiempo?** Para esta primera etapa de entrega, el sistema funcionará en **una estación central (una sola computadora principal)** donde cada empleado iniciará sesión con su usuario según su turno o proceso. A futuro nos encantaría conectarlo en red local (una PC en báscula y otra en caja apuntando a la misma base de datos SQL Server), pero por ahora no tiene que preocuparse por choques de concurrencia en tiempo real; basta con que la base de datos gestione bien los IDs para que no se dupliquen los registros.

**3. ¿Hay algún tipo de ID en específico que le gustaría seguir para empleados? (ej. las dos primeras letras del puesto y un número incremental)** ¡Su propuesta nos parece excelente y muy ordenada! Nos encantaría ver códigos con ese formato:

- **Administrador:** `AD-001`
    
- **Recepcionista:** `RE-001`
    
- **Cajero:** `CA-001`_(Nota técnica de parte nuestra: Si para facilitar las relaciones de llaves foráneas en su base de datos SQL Server usted prefiere usar un `ID` numérico autoincremental interno y manejar este código `AD-001` como un campo visual o código de empleado generado por el programa, tiene total libertad de hacerlo como mejor le convenga a su arquitectura)._
    
**4. En la diferenciación de roles, ¿el Recepcionista puede ver lo que el Cajero hace o prefiere que se oculte el acceso total según su rol?** Preferimos que **cada quien vaya estrictamente a lo suyo**. Por seguridad financiera y orden operativo, queremos que las funciones que no corresponden al rol **se oculten o se bloqueen por completo** en el menú principal:

- **El Recepcionista** solo debe tener habilitados los módulos de _Productores_ y _Recepción de Lotes_. No tiene por qué ver ni entrar a la pantalla de pagos/liquidaciones.
    
- **El Cajero** solo debe acceder al módulo de _Liquidaciones/Pagos_ y _Reportes/Historial_.
    
- **El Administrador** es el único con acceso total a todos los formularios, incluyendo el registro de _Empleados_ y ajuste de _Precios de Café_.
    

**5. ¿Hay alguna validación de correo? ¿Como un correo propio de la cooperativa?** Sí, manejamos dos reglas distintas:

- **Para Empleados:** Todos deben tener correo institucional obligatorio bajo nuestro dominio **`@cafedorado.com.ni`** (o `@cafedorado.com`).
    
- **Para Productores:** Como son agricultores independientes, muchos usan correos personales (`@gmail.com`, `@hotmail.com`, etc.), por lo que con ellos basta validar que tenga formato válido (que contenga `@` y un `.`). Incluso, para el productor el correo puede ser opcional o tener un valor por defecto si es un señor del campo que solo usa teléfono celular.
    

**6. ¿Cómo le gustaría generar el usuario del empleado?** Nos gustaría que el sistema **lo genere automáticamente** a partir de su nombre para mantener un estándar y evitar que pongan apodos. Por ejemplo: **la primera letra de su primer nombre + su primer apellido + las dos letras de su rol** (o un número).

- _Ejemplo:_ Si se registra a **Juan Pérez** como **Recepcionista**, su usuario generado sería `jperez.re` (o simplemente `jperez01`, todo en minúsculas y sin espacios).
    

**7. ¿Qué validaciones deberá tener la contraseña del empleado?** Como manejamos dinero y pagos delicados, necesitamos que al crear o registrar la contraseña de un empleado el sistema recorra el texto y valide que cumpla con:

- Mínimo **8 caracteres** de longitud.
- Al menos **una letra mayúscula**.
- Al menos **una letra minúscula**.    
- Al menos **un número**
- Sin espacios en blanco.

**8. ¿Cuántos intentos deberá tener el empleado antes de entrar al sistema y qué pasará si usa todos los intentos?** El empleado tendrá un máximo de **3 intentos** para iniciar sesión.

- Si falla en el intento 1 o 2, el sistema debe mostrarle un aviso indicando cuántos intentos le quedan.

- Si falla el **3er intento**, el sistema debe mostrar una alerta de seguridad (_"Acceso bloqueado por seguridad tras 3 intentos fallidos"_), deshabilitar el botón de ingreso (o cerrar el programa / cambiar el estado del usuario a bloqueado) para evitar que alguien intente adivinar contraseñas a la fuerza.

**9. ¿Cómo le gustaría registrar los siguientes IDs: productores, café, lotes y recibos?** Siguiendo la misma línea limpia que usted propuso, nos gustaría esta nomenclatura visual:

- **Productores:** `PROD-001`, `PROD-002`...
	
- **Variedades de Café:** `CAF-01` al `CAF-04` (o simplemente `1, 2, 3, 4` ya que es un catálogo pequeño)  
    
- **Lotes recibidos:** `LOT-0001`, `LOT-0002`..  
    
- **Recibos / Liquidaciones:** `LIQ-0001`, `LIQ-0002`..._(De nuevo, siéntase libre de usar llaves primarias enteras `INT IDENTITY` en SQL Server para las uniones de tablas y mostrar estos prefijos formateados en pantalla o en una columna de código alterna)._
    

**10. ¿El precio base por kilo está estandarizado como me lo dijo en la pregunta 16 o cambia con el tiempo?** Los precios que le di (`C$ 100`, `C$ 115`, `C$ 125` y `C$ 145`) son nuestros precios oficiales para abrir esta cosecha, pero en el mundo real el precio del café sube o baja según la bolsa y la temporada. Por lo tanto, lo ideal es que esos 4 precios **estén guardados en la tabla de Variedades de Café en la base de datos** (o puedan ser editados por el Administrador), para que si el próximo mes el Caturra sube a `C$ 120`, el sistema tome el precio actualizado sin tener que modificar el código fuente.


**11. ¿Le parecería discutir luego en qué estructura del contenido desea crear los comprobantes/reportes y liquidaciones? (por ejemplo, un encabezado y la estructura del texto)** **¡Me parece perfecto, Ingeniero!** Dejemos el diseño detallado de las plantillas de los documentos PDF y las hojas de Excel para la siguiente fase del proyecto. En este primer avance de noviembre, nuestra prioridad absoluta es ver la base de datos conectada, las validaciones funcionando, los cálculos exactos y los formularios principales operando con la identidad visual que hablamos.

  

Con esto tiene luz verde de nuestra parte para arrancar con el modelado de la base de datos y los primeros formularios. Si necesita validar sus tablas de SQL Server o cualquier lógica antes de programar, aquí estamos a la orden. ¡Adelante!


# DISEÑO DE DATOS
## PROTOTIPO DE TODAS LAS TABLAS:

| **Empleados**   | **Productores** | **Café**    | **LotesCafé**      | **LiquidacionCafé** |
| :-------------- | --------------- | ----------- | ------------------ | ------------------- |
| ID_Empleado     | ID_Productor    | ID_TipoCafe | ID_Lote            | ID_Pago             |
| Codigo          | Codigo          | TipoCafé    | Codigo             | Codigo              |
| Cedula          | Cedula          | PrecioXKilo | Fecha_Recepcion    | FechaEmision        |
| Nombre_Completo | Nombre_Completo | Descripcion | ID_Productor       | ID_lotes            |
| Telefono        | Nombre_Finca    |             | ID_TipoCafé        | Total_Kilos_Netos   |
| Correo          | Ubicacion       |             | CantidadSacos      | Precio_kilo_Base    |
| Usuario         | Altitud         |             | KilosBrutos        | PrecioXCalidad      |
| Contraseña      | Correo          |             | DescuentoXSacos    | SubtotalXCafé       |
| Rol             | Telefono        |             | KilosNetos         | Bonificaciones      |
| Estado          | Categoria       |             | PorcentajeHumedad  | Retencion           |
|                 | Estado          |             | PorcentajeDefectos | Monto_Total_Neto    |
|                 |                 |             | Calidad            | Metodo_Pago         |
|                 |                 |             | ID_Empleado        |                     |
|                 |                 |             | Estado             |                     |


# TABLAS REALIZADAS
## EMPLEADOS

| **EMPLEADOS**   | **Tipo de dato** | PK  FK      |
| :-------------- | ---------------- | ----------- |
| EmpleadoID      | INT IDENTITY     | PRIMARY KEY |
| Codigo          | NVARCHAR         |             |
| Cedula          | NVARCHAR         |             |
| Nombre_Completo | NVARCHAR         |             |
| Telefono        | NVARCHAR         |             |
| Correo          | NVARCHAR         |             |
| Usuario         | NVARCHAR         |             |
| Contraseña      | NVARCHAR         |             |
| Rol             | NVARCHAR         |             |
| Estado          | NVARCHAR         |             |

## PRODUCTORES

| **PRODUCTORES** | **Tipo de dato** | PK/FK       |
| :-------------- | ---------------- | ----------- |
| ProductorID     | INT IDENTITY     | PRIMARY KEY |
| Codigo          | NVARCHAR         |             |
| Cedula          | NVARCHAR         |             |
| Nombre_Completo | NVARCHAR         |             |
| Nombre_finca    | NVARCHAR         |             |
| Ubicacion       | NVARCHAR         |             |
| Altitud         | NVARCHAR         |             |
| Correo          | NVARCHAR         |             |
| Telefono        | NVARCHAR         |             |
| Categoria       | NVARCHAR         |             |
| Estado          | NVARCHAR         |             |

**NOTA:** Los valores del campo *Codigo* esta calculado mediante la siguiente formula Codigo AS ('PROD-' + RIGHT('00000' + CAST(ProductorID AS VARCHAR(10)), 5)) PERSISTED,

## CAFE

| **CAFE**      | **Tipo de dato** | PK/FK       |
| :------------ | ---------------- | ----------- |
| TipoCafeID    | INT IDENTITY     | PRIMARY KEY |
| TipoCafe      | NVARCHAR         |             |
| PrecioPorKilo | DECIMAL          |             |
| Descripcion   | NVARCHAR         |             |
%%se me olvido automatizar el código del Café xd%%


## LOTESCAFE

| **LOTESCAFE**      | **Tipo de dato** | PK/FK       |
| :----------------- | ---------------- | ----------- |
| LoteID             | INT IDENTITY     | PRIMARY KEY |
| Codigo             | NVARCHAR         |             |
| Fecha_Recepcion    | DATE             |             |
| ProductorID        | INT              | FOREIGN KEY |
| TipoCafeID         | INT              | FOREIGN KEY |
| EmpleadoID         | INT              | FOREIGN KEY |
| CantidadSacos      | INT              |             |
| KilosBrutos        | DECIMAL          |             |
| TaraSacos          | DECIMAL          |             |
| KilosNetos         | DECIMAL          |             |
| PorcentajeHumedad  | DECIMAL          |             |
| PorcentajeDefectos | DECIMAL          |             |
| Calidad            | NVARCHAR         |             |

**NOTAS:**
1. Los valores del campo *Codigo* al igual que en la tabla Productores tambien esta automatizada para que muestre LOTE- y el numero de ID
2. La *tara* o diferencia de kilo por el saco esta programado en ya en la tabla multiplicando la cantidad de sacos por 0.5Kg el peso estandar de los sacos
3. Los valores del campo *KilosNetos* tambien esta calculada mediante la difetencia de el pesaje de kilos que dio menos la tara de sacos
4. Los valores del campo *Calidad* tambien esta automatizado, mediante un bloque de codigo CASE-END que segun el porcentaje de humedad y de defectos muestra la calidad solicitada


## LIQUIDACIONES

| **LIQUIDACIONES** |              |
| :---------------- | ------------ |
| LiquidacionID     | INT IDENTITY |
| Codigo            | NVARCHAR     |
| FechaEmision      | DATE         |
| LoteID            | INT          |
| KilosNetos        | DECIMAL      |
| PrecioPorKilo     | DECIMAL      |
| PrecioPorCalidad  | DECIMAL      |
| SubtotalLote      | DECIMAL      |
| Bonificaciones    | DECIMAL      |
| Retenciones       | DECIMAL      |
| TotalAPagar       | DECIMAL      |
| Estado            | NVARCHAR     |
| MetodoPago        | NVARCHAR     |

**NOTA:** 
Los valores de los campos Codigo, SubtotalLote y TotalAPagar Son automaticos, programados en la tabla de la base de datos 





[^1]: Acopio: a acción y el efecto de **juntar, reunir o almacenar** una gran cantidad de algo de forma voluntaria y con un propósito específico (como crear reservas, juntar víveres o recolectar materiales)
