# Programación Tolerante a Errores/Fallas

Hacer sistemas que puedan solventar problematicas que puedas pasar en el futuro, 
es una de las mejores formas de evitar problemas a largo plazo, y es algo que se debe tener en cuenta a la hora de programar, 
ya que no siempre se pueden prever todos los posibles errores que puedan surgir, 
pero si se pueden prever algunos, y es importante tener en cuenta eso a la hora de programar.

Ejemplos de casos:
- Caida de red
- Fallas de hardware
- Errores de usuario
- Sobrecarga de sistema
- Mal diseño de software
- Errores de programación
- Archivos corruptos
- Errores de seguridad
- Errores de compatibilidad

---

## Error -> Defecto -> Falla

Diferencia entre error, defecto y falla:
- Error
	- Condición incorrecta
	- Acción humana
	- Lógica incorrecta
	- Ejemplos:
		- Suponer un requerimiento
		- Configuración errónea
		- Error de lógica (Usar OR en lugar de AND)
		- 
- Defecto (Bug)
	- Representación Técnica de un error
	- Se puede detectar con pruebas
	- Ejemplos:
		- Posición incorrecta de un array
		- División por cero
- Falla
	- Manifestación observable de un error o defecto
	- Comportamiento Inesperado
	- Se manifiesta al ejecutar
	- Ejemplos:
		- Se cierra la App
		- No responde el API

