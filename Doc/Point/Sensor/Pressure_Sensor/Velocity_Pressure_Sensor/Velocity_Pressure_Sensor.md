[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Velocity_Pressure_Sensor](.)
# Velocity_Pressure_Sensor

**Display name:** Velocity Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Velocity_Pressure_Sensor;1

---


## Child interfaces
* [Discharge_Air_Velocity_Pressure_Sensor](Discharge_Air_Velocity_Pressure_Sensor.md)
* [Exhaust_Air_Velocity_Pressure_Sensor](Exhaust_Air_Velocity_Pressure_Sensor.md)
* [Supply_Air_Velocity_Pressure_Sensor](Supply_Air_Velocity_Pressure_Sensor.md)

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
