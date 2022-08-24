[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Differential_Pressure_Sensor](#)
# Differential_Pressure_Sensor

**Display name:** Differential Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Sensor;1

---


## Child interfaces
* [Chilled_Water_Differential_Pressure_Sensor](Chilled_Water_Differential_Pressure_Sensor.md)
* [Filter_Differential_Pressure_Sensor](Filter_Differential_Pressure_Sensor.md)
* [Air_Differential_Pressure_Sensor](Air_Differential_Pressure_Sensor/Air_Differential_Pressure_Sensor.md)
* [Hot_Water_Differential_Pressure_Sensor](Hot_Water_Differential_Pressure_Sensor/Hot_Water_Differential_Pressure_Sensor.md)

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
