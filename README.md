https://digital-standard.com/threedpose/models/Resnet34_3inputs_448x448_20200609.onnx

### Configuraciones en Unity Inspector
1. Abra el proyecto de Unity con Unity Editor y coloque el archivo onnx en /Assets/Scripts/Model/
    En esta acción, el archivo onnx se convierte automáticamente en el tipo NNModel de Barracuda.

2. Abra "SampleScene" en la carpeta "Scene".
    Si aparece un cuadro de diálogo, seleccione "No guardar".
    
3. Establecer modelo
    Arrastra el NNModel que pusiste antes en Activos/Scripts/Modelo/
    y colóquelo en "Modelo NN" en Gameobject llamado "BarracudaRunner" en la vista Inspector.
