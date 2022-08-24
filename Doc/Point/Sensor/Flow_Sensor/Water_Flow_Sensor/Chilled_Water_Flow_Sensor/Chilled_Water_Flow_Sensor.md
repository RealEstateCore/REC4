[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Flow_Sensor](../../Flow_Sensor.md) > [Water_Flow_Sensor](../Water_Flow_Sensor.md) > [Chilled_Water_Flow_Sensor](#)
# Chilled_Water_Flow_Sensor

**Display name:** Chilled Water Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Water_Flow_Sensor;1

---


## Child interfaces
* [Entering_Chilled_Water_Flow_Sensor](../Entering_Water_Flow_Sensor/Entering_Chilled_Water_Flow_Sensor.md)
* [Leaving_Chilled_Water_Flow_Sensor](../Leaving_Water_Flow_Sensor/Leaving_Chilled_Water_Flow_Sensor.md)

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
