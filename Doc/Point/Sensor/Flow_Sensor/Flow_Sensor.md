[Point](../../Point.md) > [Sensor](../Sensor.md) > [Flow_Sensor](#)
# Flow_Sensor

**Display name:** Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Flow_Sensor;1

---


## Child interfaces
* [Natural_Gas_Flow_Sensor](Natural_Gas_Flow_Sensor.md)
* [Air_Flow_Sensor](Air_Flow_Sensor/Air_Flow_Sensor.md)
* [Water_Flow_Sensor](Water_Flow_Sensor/Water_Flow_Sensor.md)

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
