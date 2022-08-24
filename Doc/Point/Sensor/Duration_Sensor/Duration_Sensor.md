[Point](../../Point.md) > [Sensor](../Sensor.md) > [Duration_Sensor](#)
# Duration_Sensor

**Display name:** Duration Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Duration_Sensor;1

---


## Child interfaces
* [On_Timer_Sensor](On_Timer_Sensor.md)
* [Rain_Duration_Sensor](../Rain_Sensor/Rain_Duration_Sensor.md)
* [Run_Time_Sensor](Run_Time_Sensor.md)

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
