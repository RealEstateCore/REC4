[Point](../../Point.md) > [Sensor](../Sensor.md) > [Pressure_Sensor](#)
# Pressure_Sensor

**Display name:** Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Pressure_Sensor;1

---


## Child interfaces
* [Differential_Pressure_Sensor](Differential_Pressure_Sensor/Differential_Pressure_Sensor.md)
* [Static_Pressure_Sensor](Static_Pressure_Sensor/Static_Pressure_Sensor.md)
* [Velocity_Pressure_Sensor](Velocity_Pressure_Sensor/Velocity_Pressure_Sensor.md)

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
