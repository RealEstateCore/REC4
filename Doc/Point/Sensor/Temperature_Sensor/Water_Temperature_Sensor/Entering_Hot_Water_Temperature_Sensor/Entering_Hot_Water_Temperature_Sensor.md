[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Entering_Hot_Water_Temperature_Sensor](.)
# Entering_Hot_Water_Temperature_Sensor

**Display name:** Entering Hot Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Hot_Water_Temperature_Sensor;1

---


## Child interfaces
* [Entering_Domestic_Hot_Water_Temperature_Sensor](Entering_Domestic_Hot_Water_Temperature_Sensor.md)
* [Entering_High_Temperature_Hot_Water_Temperature_Sensor](Entering_High_Temperature_Hot_Water_Temperature_Sensor.md)
* [Entering_Medium_Temperature_Hot_Water_Temperature_Sensor](Entering_Medium_Temperature_Hot_Water_Temperature_Sensor.md)
* [Hot_Water_Differential_Temperature_Sensor](../Leaving_Hot_Water_Temperature_Sensor/Hot_Water_Differential_Temperature_Sensor.md)

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
