[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Temperature_Sensor](../Temperature_Sensor.md) > [Radiant_Panel_Temperature_Sensor](.)
# Radiant_Panel_Temperature_Sensor

**Display name:** Radiant Panel Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Radiant_Panel_Temperature_Sensor;1

---


## Child interfaces
* [Inside_Face_Surface_Temperature_Sensor](Inside_Face_Surface_Temperature_Sensor.md)
* [Outside_Face_Surface_Temperature_Sensor](Outside_Face_Surface_Temperature_Sensor.md)
* [Embedded_Temperature_Sensor](Embedded_Temperature_Sensor/Embedded_Temperature_Sensor.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
