#Binding con Commands


> Escenario 1: Terminar el CRUD con los bingins, tener en cuenta que lo binding se pueden intercambiar por los x:bind 
pero no tienen tanta potencia.
>>`Binding & x:Bind`


#### Datos a tener en cuenta
Todos los metodos han sido cambiados en `MainPageVM` de:<br/>
<br/>
```
if (handler != null)
  handler(this, new PropertyChangedEventArgs(v));
```
por:
```
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));

```
> Así conseguimos una escritura más rapida y mayor eficacia en el codigo `Linq Code`.
