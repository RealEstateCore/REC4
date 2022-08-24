[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Chilled_Water_Temperature_Sensor](.)
# Chilled_Water_Temperature_Sensor

**Display name:** Chilled Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Water_Temperature_Sensor;1

---


## Child interfaces
* [Chilled_Water_Differential_Temperature_Sensor](../Water_Differential_Temperature_Sensor/Chilled_Water_Differential_Temperature_Sensor.md)
* [Differential_Entering_Leaving_Water_Temperature_Sensor](Differential_Entering_Leaving_Water_Temperature_Sensor.md)
* [Entering_Chilled_Water_Temperature_Sensor](Entering_Chilled_Water_Temperature_Sensor.md)
* [Leaving_Chilled_Water_Temperature_Sensor](Leaving_Chilled_Water_Temperature_Sensor.md)

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
