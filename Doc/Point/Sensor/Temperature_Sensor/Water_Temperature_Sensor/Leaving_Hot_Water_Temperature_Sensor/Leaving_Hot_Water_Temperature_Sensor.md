[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Leaving_Hot_Water_Temperature_Sensor](.)
# Leaving_Hot_Water_Temperature_Sensor

**Display name:** Leaving Hot Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Hot_Water_Temperature_Sensor;1

---


## Child interfaces
* [Leaving_Domestic_Hot_Water_Temperature_Sensor](Leaving_Domestic_Hot_Water_Temperature_Sensor.md)
* [Hot_Water_Differential_Temperature_Sensor](Hot_Water_Differential_Temperature_Sensor.md)
* [Leaving_High_Temperature_Hot_Water_Temperature_Sensor](Leaving_High_Temperature_Hot_Water_Temperature_Sensor.md)
* [Leaving_Medium_Temperature_Hot_Water_Temperature_Sensor](Leaving_Medium_Temperature_Hot_Water_Temperature_Sensor.md)

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
