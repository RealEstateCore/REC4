[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Temperature_Sensor](../../Temperature_Sensor.md) > [Water_Temperature_Sensor](../Water_Temperature_Sensor.md) > [Leaving_Water_Temperature_Sensor](#)
# Leaving_Water_Temperature_Sensor

**Display name:** Leaving Water Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Water_Temperature_Sensor;1

---


## Child interfaces
* [Heat_Exchanger_Leaving_Water_Temperature_Sensor](Heat_Exchanger_Leaving_Water_Temperature_Sensor.md)
* [Ice_Tank_Leaving_Water_Temperature_Sensor](Ice_Tank_Leaving_Water_Temperature_Sensor.md)

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
